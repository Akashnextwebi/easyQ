using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_template : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strTemplateDocument = "", strImage = "", strTemplates = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSave.Attributes.Add("onclick", " this.disabled = 'true';this.value='Please Wait...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");

        GetAllTemplates();
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetTemplates();
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                string pageTemplate = Path.GetFileName(Request.Path);
                string resmsg = CheckImageFormat();
                if (resmsg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                    return;
                }
                else if (resmsg == "Size")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Image size should be 650*450 px',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                    return;
                }
                string respdf = CheckPDFFormat();
                if (respdf == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid file format.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    return;
                }
                string pageName = Path.GetFileName(Request.Path);
                Templates cs = new Templates();
                List<Templates> res = Templates.GetTemplatesByName(conEQ, txtTemplate.Text.Trim().ToLower());
                if (btnSave.Text == "Update")
                {
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.Template = txtTemplate.Text.Trim();
                    cs.Featured = chkFeatured.Checked ? "Yes" : "No";
                    cs.PostedOn = txtPostedOn.Text.Trim();
                    cs.Image = UploadImage();
                    cs.Document = UploadPDFFormat();
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        if (res.Count > 0 && res[0].Id != Convert.ToInt32(Request.QueryString["id"]))
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Template already exist...',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                            return;
                        }
                        else
                        {
                            int result = Templates.UpdateTemplates(conEQ, cs);
                            if (result > 0)
                            {
                                GetAllTemplates();
                                GetTemplates();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Template updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Access denied. Contact to your administrator',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    cs.Template = txtTemplate.Text.Trim();
                    cs.Featured = chkFeatured.Checked ? "Yes" : "No";
                    cs.Image = UploadImage();
                    cs.PostedOn = txtPostedOn.Text.Trim();
                    cs.Document = UploadPDFFormat();
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (cs.Image == "")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Please Upload Image',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        return;
                    }
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        if (res.Count > 0)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Template already exist...',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                            return;
                        }
                        else
                        {
                            int result = Templates.InsertTemplates(conEQ, cs);
                            if (result > 0)
                            {
                                txtTemplate.Text = "";
                                GetAllTemplates();
                                GetTemplates();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Template added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Access denied. Contact to your administrator',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }

                }
            }
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSave_Click", ex.Message);
        }
    }
    public void GetAllTemplates()
    {
        try
        {
            strTemplates = "";
            List<Templates> cas = Templates.GetAllTemplates(conEQ).OrderByDescending(s => Convert.ToDateTime(s.PostedOn)).ToList();
            int i = 0;
            foreach (Templates nb in cas)
            {
                strTemplates += @"<tr>
                                     <td>" + (i + 1) + @"</td>  
                                    <td><a href='/" + nb.Image + @"' target='_blank'><img style = 'max-height:50px;' src='/" + nb.Image + @"' alt='' data-image='/" + nb.Image + @"'> </a></td>
                                    <td>" + nb.Template + @"</td>
                                    <td><strong><u><a download href='/" + nb.Document + @"' target='_blank'>Click here</a></u></strong></td>
                                     <td><a href='javascript:void();' class='bs-tooltip' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title=''>" + nb.AddedOn.ToString("dd-MMM-yyyy") + @"</a></td>  
                                     <td class='text-center'>
                                            <a href='manage-template.aspx?id=" + nb.Id + @"' class='bs-tooltip fs-18 link-info' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                             <a href='javascript:void(0);' class='bs-tooltip fs-18 link-danger deleteItem' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title='Delete'>
                                                <i class='mdi mdi-trash-can-outline'></i></a></td>
                                      </tr>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTemplates", ex.Message);
        }
    }
    public void GetTemplates()
    {
        try
        {
            Templates PD = Templates.GetTemplatesById(conEQ, Convert.ToInt32(Request.QueryString["id"])).FirstOrDefault();
            if (PD != null)
            {

                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtTemplate.Text = PD.Template;
                txtPostedOn.Text = PD.PostedOn;
                chkFeatured.Checked = PD.Featured == "Yes" ? true : false;
                if (PD.Image != "")
                {
                    lblThumb.Text = PD.Image;
                    strImage = @"<img src='/" + PD.Image + @"' class='img-responsive ms-3' width='80px' height='60px' title='" + PD.Image + @"'/>";
                }
                if (PD.Document != "")
                {
                    lblPdf.Text = PD.Document;
                    strTemplateDocument = @"<a download href='/" + PD.Document + @"'><img src='assets/images/pdf.png' class='img-responsive' width='60px' height='60px' title='" + PD.Document + @"'/></a>";
                }

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTemplates", ex.Message);
        }
    }
    protected void addNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage-template.aspx");
    }

    [WebMethod(EnableSession = true)]
    public static string DeleteTemplates(string id)
    {
        string x = "";
        try
        {
            SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
            if (CreateUser.CheckAccess(conEQ, "manage-template.aspx", "Delete", HttpContext.Current.Request.Cookies["eq_aid"].Value))
            {
                Templates cat = new Templates();
                cat.Id = Convert.ToInt32(id);
                cat.AddedBy = HttpContext.Current.Request.Cookies["eq_aid"].Value;
                cat.AddedOn = TimeStamps.UTCTime();
                cat.AddedIp = CommonModel.IPAddress();
                int exec = Templates.DeleteTemplates(conEQ, cat);
                if (exec > 0)
                {
                    x = "Success";
                }
            }
            else
            {
                x = "Permission";
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteTemplates", ex.Message);
        }
        return x;
    }
    private string CheckPDFFormat()
    {
        #region PDF
        string UploadPdf = "";
        if (TemplateDocument.HasFile)
        {
            try
            {
                string fileExtension = Path.GetExtension(TemplateDocument.PostedFile.FileName.ToLower()),
                ImageGuid1 = Guid.NewGuid().ToString() + "_template".Replace(" ", "-").Replace(".", "");
                if ((fileExtension == ".pdf" || fileExtension == ".docx" || fileExtension == ".ppt" || fileExtension == ".pptx" || fileExtension == ".doc"))
                {
                    string iconPath = Server.MapPath(".") + "\\../UploadDocuments\\" + ImageGuid1 + fileExtension;
                }
                else
                {
                    return "Format";
                }
            }
            catch (Exception ex)
            {
                ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "CheckPDFFormat", ex.Message);

            }
        }
        #endregion
        return UploadPdf;
    }
    public string UploadPDFFormat()
    {
        #region upload file
        string thumbfile = "";
        try
        {
            if (TemplateDocument.HasFile)
            {
                string fileExtension = Path.GetExtension(TemplateDocument.PostedFile.FileName.ToLower()),
                ImageGuid1 = Guid.NewGuid().ToString() + "_template".Replace(" ", "-").Replace(".", "");
                string iconPath = Server.MapPath(".") + "\\../UploadDocuments\\" + ImageGuid1 + "" + fileExtension;
                TemplateDocument.SaveAs(iconPath);
                thumbfile = "UploadDocuments/" + ImageGuid1 + "" + fileExtension;
            }
            else
            {
                thumbfile = lblPdf.Text;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UploadPDFFormat", ex.Message);

        }

        #endregion
        return thumbfile;
    }
    public string CheckImageFormat()
    {
        #region upload image
        string thumbImage = "";
        if (FileUpload1.HasFile)
        {
            string fileExtension = Path.GetExtension(FileUpload1.PostedFile.FileName.ToLower());

            if ((fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png" || fileExtension == ".gif" || fileExtension == ".webp"))
            {
                if (fileExtension == ".webp")
                {
                    return thumbImage;
                }
                else
                {
                    System.Drawing.Bitmap bmpPostedImageBig = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);
                    System.Drawing.Image objImagesmallBig = CommonModel.ScaleImageBig(bmpPostedImageBig, bmpPostedImageBig.Height, bmpPostedImageBig.Width);
                    if (bmpPostedImageBig.Height != 450 && bmpPostedImageBig.Width != 650)
                    {
                        return "Size";
                    }
                }

            }
            else
            {
                return "Format";
            }
        }
        #endregion
        return thumbImage;
    }
    public string UploadImage()
    {
        #region upload image
        string thumbImage = "";
        if (FileUpload1.HasFile)
        {
            string fileExtension = Path.GetExtension(FileUpload1.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-Templatesimg".Replace(" ", "-").Replace(".", "");
            string iconPath = Server.MapPath(".") + "\\../UploadImages\\" + ImageGuid1 + "" + fileExtension;
            try
            {
                if (File.Exists(Server.MapPath("~/" + Convert.ToString(lblThumb.Text))))
                {
                    File.Delete(Server.MapPath("~/" + Convert.ToString(lblThumb.Text)));
                }
            }
            catch (Exception eeex)
            {
                ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "UploadImage", eeex.Message);
                return lblThumb.Text;
            }

            if (fileExtension == ".webp")
            {
                FileUpload1.SaveAs(iconPath);

            }
            else if (fileExtension == ".gif")
            {
                FileUpload1.SaveAs(iconPath);

            }
            else
            {
                System.Drawing.Bitmap bmpPostedImageBig = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);
                System.Drawing.Image objImagesmallBig = CommonModel.ScaleImageBig(bmpPostedImageBig, bmpPostedImageBig.Height, bmpPostedImageBig.Width);
                if (fileExtension == ".png")
                {
                    CommonModel.SavePNG(iconPath, objImagesmallBig, 99);
                }
                else { CommonModel.SaveJpeg(iconPath, objImagesmallBig, 99); }
            }
            thumbImage = "UploadImages/" + ImageGuid1 + "" + fileExtension;
        }
        else
        {
            thumbImage = lblThumb.Text;
        }
        #endregion
        return thumbImage;
    }
}