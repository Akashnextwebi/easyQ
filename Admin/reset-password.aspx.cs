using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_reset_password : System.Web.UI.Page
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
                string logins = CreateUser.CheckResetLink(conEQ, Request.QueryString["r"]);
                if (logins != "")
                {
                    string pwd = CommonModel.Encrypt(txtPassword.Text.Trim());
                    int x = CreateUser.SetResetTiming(conEQ, Request.QueryString["r"], pwd);
                    if (x > 0)
                    {
                        lblStatus.Text = "<strong>Success !</strong><br/>Password changed successfully";
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
                    lblStatus.Text = "<strong>Error !</strong><br/>Invalid link";
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