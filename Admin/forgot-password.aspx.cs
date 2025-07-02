using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_forgot_password : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        lblStatus.Visible = true;
        try
        {
            if (Page.IsValid)
            {
                string logins = CreateUser.ResetPassword(conEQ, txtEmail.Text.Trim());
                if (logins != "")
                {
                    string r_id = Guid.NewGuid().ToString();
                    int reset = CreateUser.SetRestId(conEQ, logins, r_id);
                    var username = CreateUser.GetLoggedUserName(conEQ, Convert.ToString(logins));
                    Emails.SendPasswordRestLink(logins, txtEmail.Text.Trim(), ConfigurationManager.AppSettings["domain"] + "/admin/reset-password.aspx?r=" + r_id);
                    if (reset > 0)
                    {
                        lblStatus.Text = "<strong>Success !</strong><br/>Password reset link has been sent to your email address";
                        lblStatus.Attributes.Add("class", "alert alert-success d-block");
                    }
                    else
                    {
                        lblStatus.Text = "<strong>Error !</strong><br/>There is some problem now. Please try after some time";
                        lblStatus.Attributes.Add("class", "alert alert-danger d-block");
                    }
                }
                else
                {
                    lblStatus.Text = "<strong>Error !</strong><br/>Entered email is not registered";
                    lblStatus.Attributes.Add("class", "alert alert-danger d-block");
                }
            }
        }
        catch (Exception ex)
        {
            lblStatus.Text = "<strong>Error !</strong><br/>There is some problem now. Please try after some time";
            lblStatus.Attributes.Add("class", "alert alert-danger d-block");
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnLogin_Click", ex.Message);
        }
    }
}