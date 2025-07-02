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

public partial class Admin_add_testimonials : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strTestimonials = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSave.Attributes.Add("onclick", " this.disabled = 'true';this.value='Please Wait...'; " + ClientScript.GetPostBackEventReference(btnSave, null) + ";");
        GetAllTestimonials();
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                GetTestimonials();
            }
        }

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                string pageName = Path.GetFileName(Request.Path);
                Testimonials cs = new Testimonials();
                if (btnSave.Text == "Update")
                {
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.UserName = txtName.Text.Trim();
                    cs.Designation = txtDesignation.Text.Trim();
                    cs.Rating = ddlStar.SelectedItem.Value;
                    cs.Details = txtDetails.Text.Trim();
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        int result = Testimonials.UpdateTestimonials(conEQ, cs);
                        if (result > 0)
                        {
                            GetAllTestimonials();
                            GetTestimonials();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Testimonials updated successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
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
                    cs.UserName = txtName.Text.Trim();
                    cs.Designation = txtDesignation.Text.Trim();
                    cs.Rating = ddlStar.SelectedItem.Value;
                    cs.Details = txtDetails.Text.Trim();
                    cs.Id = Convert.ToInt32(Request.QueryString["id"]);
                    cs.AddedIp = CommonModel.IPAddress();
                    cs.AddedOn = TimeStamps.UTCTime();
                    cs.Status = "Active";
                    cs.AddedBy = Request.Cookies["eq_aid"].Value;
                    if (CreateUser.CheckAccess(conEQ, pageName, "edit", Request.Cookies["eq_aid"].Value))
                    {
                        int result = Testimonials.InsertTestimonials(conEQ, cs);
                        if (result > 0)
                        {
                            txtName.Text = txtDetails.Text = txtDesignation.Text = ddlStar.Text = "";
                            GetAllTestimonials();
                            GetTestimonials();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "Snackbar.show({pos: 'top-right',text: 'Testimonials added successfully.',actionTextColor: '#fff',backgroundColor: '#008a3d'});", true);
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
    public void GetAllTestimonials()
    {
        try
        {
            strTestimonials = "";
            List<Testimonials> cas = Testimonials.GetAllTestimonials(conEQ).OrderByDescending(s => Convert.ToDateTime(s.AddedOn)).ToList();
            int i = 0;
            foreach (Testimonials nb in cas)
            {

                strTestimonials += @"<tr>
                                 <td>" + (i + 1) + @"</td>  
                                <td>" + nb.UserName + @"</td>
                                <td>" + nb.Rating + @"</td>
                                <td>" + nb.Designation + @"</td>
                                 <td class='text-wrap-auto'>" + nb.Details + @"</td>
                                 <td><a href='javascript:void();' class='bs-tooltip' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title=''>" + nb.AddedOn.ToString("dd-MMM-yyyy") + @"</a></td>  
                                 <td class='text-center'>
                                        <a href='add-testimonials.aspx?id=" + nb.Id + @"' class='bs-tooltip fs-18 link-info' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Edit'>
                                           <i class='mdi mdi-pencil'></i></a>
                                         <a href='javascript:void(0);' class='bs-tooltip fs-18 link-danger deleteItem' data-id='" + nb.Id + @"' data-bs-toggle='tooltip' data-bs-placement='top' title='Delete'>
                                            <i class='mdi mdi-trash-can-outline'></i></a></td>
                                  </tr>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTestimonials", ex.Message);
        }
    }
    public void GetTestimonials()
    {
        try
        {
            Testimonials PD = Testimonials.GetTestimonials(conEQ, Convert.ToInt32(Request.QueryString["id"])).FirstOrDefault();
            if (PD != null)
            {
                btnSave.Text = "Update";
                btnNew.Visible = true;
                txtName.Text = PD.UserName;
                ddlStar.SelectedValue = PD.Rating;
                txtDesignation.Text = PD.Designation;
                txtDetails.Text = PD.Details;

            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTestimonials", ex.Message);
        }
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("add-testimonials.aspx");
    }

    [WebMethod(EnableSession = true)]
    public static string DeleteTestimonials(string id)
    {
        string x = "";
        try
        {
            SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
            if (CreateUser.CheckAccess(conEQ, "add-testimonials.aspx", "Delete", HttpContext.Current.Request.Cookies["eq_aid"].Value))
            {
                Testimonials cat = new Testimonials();
                cat.Id = Convert.ToInt32(id);
                cat.AddedBy = HttpContext.Current.Request.Cookies["eq_aid"].Value;
                cat.AddedOn = TimeStamps.UTCTime();
                cat.AddedIp = CommonModel.IPAddress();
                int exec = Testimonials.DeleteTestimonials(conEQ, cat);
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteTestimonials", ex.Message);
        }
        return x;
    }

}