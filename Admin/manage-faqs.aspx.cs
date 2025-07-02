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

public partial class Admin_manage_faqs : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strFaqs = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSave.Attributes.Add("onclick", " this.disabled = 'true';this.value='Please Wait...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
        GetAllFAQs();
        if (!IsPostBack)
        { 
            GetFAQs();
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                string pageName = Path.GetFileName(Request.Path);
                FAQs cs = new FAQs();
                if (btnSave.Text == "Update")
                {
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.Question = txtQuestion.Text.Trim();
                    cs.DisplayOrder = txtOrder.Text.Trim();
                    cs.Answer = txtDesc.Text.Trim();
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        int result = FAQs.UpdateFAQs(conEQ, cs);
                        if (result > 0)
                        {
                            GetAllFAQs();
                            GetFAQs();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'FAQ updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Access denied. Contact to your administrator',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);
                    }
                }
                else
                {
                    cs.Question = txtQuestion.Text.Trim();
                    cs.Answer = txtDesc.Text.Trim();
                    cs.DisplayOrder = txtOrder.Text.Trim();
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        int result = FAQs.InsertFAQs(conEQ, cs);
                        if (result > 0)
                        {
                            txtDesc.Text = txtQuestion.Text =txtOrder.Text= "";
                            GetAllFAQs();
                            GetFAQs();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'FAQ added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'There is some problem now. Please try after some time',actionTextColor: '#fff',backgroundColor: '#ea1c1c'});", true);

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

    public void GetAllFAQs()
    {
        try
        {
            strFaqs = "";
            List<FAQs> cas = FAQs.GetAllFAQs(conEQ).OrderByDescending(s => Convert.ToDateTime(s.AddedOn)).ToList();
            int i = 0;
            foreach (FAQs nb in cas)
            {

                strFaqs += @"<tr>
                                 <td>" + (i + 1) + @"</td>  
                                <td>" + nb.Question + @"</td>
                                <td>" + nb.DisplayOrder + @"</td>
                                 <td><a href='javascript:void();' class='bs-tooltip' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title=''>" + nb.AddedOn.ToString("dd-MMM-yyyy") + @"</a></td>  
                                 <td class='text-center'>
                                        <a href='manage-faqs.aspx?id=" + nb.Id + @"' class='bs-tooltip fs-18 link-info' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Edit'>
                                           <i class='mdi mdi-pencil'></i></a>
                                         <a href='javascript:void(0);' class='bs-tooltip fs-18 link-danger deleteItem' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title='Delete'>
                                            <i class='mdi mdi-trash-can-outline'></i></a></td>
                                  </tr>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFAQs", ex.Message);
        }
    }
    public void GetFAQs()
    {
        try
        {
            FAQs PD = FAQs.GetFAQs(conEQ, Convert.ToInt32(Request.QueryString["id"])).FirstOrDefault();
            if (PD != null)
            {
                btnSave.Text = "Update";
                btnclear.Visible = true;
                txtDesc.Text = PD.Answer;
                txtOrder.Text = PD.DisplayOrder;
                txtQuestion.Text = PD.Question;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetFAQs", ex.Message);
        }
    }
    protected void addNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("manage-faqs.aspx");
    }

    [WebMethod(EnableSession = true)]
    public static string DeleteFAQs(string id)
    {
        string x = "";
        try
        {
            SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
            if (CreateUser.CheckAccess(conEQ, "manage-faqs.aspx", "Delete", HttpContext.Current.Request.Cookies["eq_aid"].Value))
            {
                FAQs cat = new FAQs();
                cat.Id = Convert.ToInt32(id);
                cat.AddedBy = HttpContext.Current.Request.Cookies["eq_aid"].Value;
                cat.AddedOn = TimeStamps.UTCTime();
                cat.AddedIp = CommonModel.IPAddress();
                int exec = FAQs.DeleteFAQs(conEQ, cat);
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteFAQs", ex.Message);
        }
        return x;
    }
  
}