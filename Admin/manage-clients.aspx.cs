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

public partial class Admin_manage_clients : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strClientDocument = "", strImage = "", strClients = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSave.Attributes.Add("onclick", " this.disabled = 'true';this.value='Please Wait...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");

        GetAllClients();
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetClients();
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                string pageClient = Path.GetFileName(Request.Path);
                string resmsg = CheckImageFormat();
                if (resmsg == "Format")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Invalid image format.',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                    return;
                }
                //else if (resmsg == "Size")
                //{
                //    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Image size should be 400*320 px',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

                //    return;
                //} 
                string pageName = Path.GetFileName(Request.Path);
                Clients cs = new Clients();
                List<Clients> res = Clients.GetClientsByName(conEQ, txtTitle.Text.Trim().ToLower());
                if (btnSave.Text == "Update")
                {
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.Title = txtTitle.Text.Trim();
                    cs.Image = UploadImage();
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        if (res.Count > 0 && res[0].Id != Convert.ToInt32(Request.QueryString["id"]))
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Client already exist...',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                            return;
                        }
                        else
                        {
                            int result = Clients.UpdateClients(conEQ, cs);
                            if (result > 0)
                            {
                                GetAllClients();
                                GetClients();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Client updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
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
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.Title = txtTitle.Text.Trim();
                    cs.Image = UploadImage();
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
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Client already exist...',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                            return;
                        }
                        else
                        {
                            int result = Clients.InsertClients(conEQ, cs);
                            if (result > 0)
                            {
                                txtTitle.Text = "";
                                GetAllClients();
                                GetClients();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Client added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
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
    public void GetAllClients()
    {
        try
        {
            strClients = "";
            List<Clients> cas = Clients.GetAllClients(conEQ).OrderByDescending(s => Convert.ToDateTime(s.AddedOn)).ToList();
            int i = 0;
            foreach (Clients nb in cas)
            {
                strClients += @"<tr>
                                     <td>" + (i + 1) + @"</td>  
                                    <td><a href='/" + nb.Image + @"' target='_blank'><img style = 'max-height:50px;' src='/" + nb.Image + @"' alt='' data-image='/" + nb.Image + @"'> </a></td>
                                    <td>" + nb.Title + @"</td>
                                     <td><a href='javascript:void();' class='bs-tooltip' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title=''>" + nb.AddedOn.ToString("dd-MMM-yyyy") + @"</a></td>  
                                     <td class='text-center'>
                                            <a href='manage-clients.aspx?id=" + nb.Id + @"' class='bs-tooltip fs-18 link-info' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Edit'>
                                               <i class='mdi mdi-pencil'></i></a>
                                             <a href='javascript:void(0);' class='bs-tooltip fs-18 link-danger deleteItem' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title='Delete'>
                                                <i class='mdi mdi-trash-can-outline'></i></a></td>
                                      </tr>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllClients", ex.Message);
        }
    }
    public void GetClients()
    {
        try
        {
            Clients PD = Clients.GetClientsById(conEQ, Convert.ToInt32(Request.QueryString["id"])).FirstOrDefault();
            if (PD != null)
            {

                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtTitle.Text = PD.Title;
                if (PD.Image != "")
                {
                    lblThumb.Text = PD.Image;
                    strImage = @"<img src='/" + PD.Image + @"' class='img-responsive ms-3' width='80px' height='60px' title='" + PD.Image + @"'/>";
                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetClients", ex.Message);
        }
    }
    protected void addNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage-clients.aspx");
    }

    [WebMethod(EnableSession = true)]
    public static string DeleteClients(string id)
    {
        string x = "";
        try
        {
            SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
            if (CreateUser.CheckAccess(conEQ, "manage-clients.aspx", "Delete", HttpContext.Current.Request.Cookies["eq_aid"].Value))
            {
                Clients cat = new Clients();
                cat.Id = Convert.ToInt32(id);
                cat.AddedBy = HttpContext.Current.Request.Cookies["eq_aid"].Value;
                cat.AddedOn = TimeStamps.UTCTime();
                cat.AddedIp = CommonModel.IPAddress();
                int exec = Clients.DeleteClients(conEQ, cat);
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteClients", ex.Message);
        }
        return x;
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
                    //if (bmpPostedImageBig.Height != 320 && bmpPostedImageBig.Width != 400)
                    //{
                    //    return "Size";
                    //}
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
            string fileExtension = Path.GetExtension(FileUpload1.PostedFile.FileName.ToLower()), ImageGuid1 = Guid.NewGuid().ToString() + "-Clientsimg".Replace(" ", "-").Replace(".", "");
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