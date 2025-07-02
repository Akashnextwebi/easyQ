using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contact_us : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string postBack = ClientScript.GetPostBackEventReference(btnSubmit, null);
            btnSubmit.Attributes.Add("onclick",
                "if (Page_ClientValidate()) { this.disabled = true; this.value='Please Wait...'; " + postBack + "; } else { return false; }");
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsValid)
            {
                ContactUs contact = new ContactUs();
                contact.UserName = txtName.Text.Trim();
                contact.EmailId = txtEmail.Text.Trim();
                contact.ContactNo = txtPhone.Text.Trim();
                contact.Message = txtMessage.Text.Trim();
                int result = ContactUs.InserContactUs(conEQ, contact);
                if (result > 0)
                {
                    Emails.ContactRequestToAdmin(contact);
                    Emails.ContactUSRequestToCustomer(contact.UserName, contact.EmailId);
                    txtName.Text = txtEmail.Text = txtPhone.Text = txtMessage.Text = "";
                    lblStatus.Visible = true;   
                    lblStatus.CssClass = "alert alert-success d-block";
                    lblStatus.Text = "Thank you! We will reach out to you soon.";
                }
                else
                {
                    lblStatus.Visible = true;
                    lblStatus.CssClass = "alert alert-danger d-block";
                    lblStatus.Text = "There was an error processing your request. Please try again later.";

                }
            }
        }
        catch (Exception ex)
        {
            lblStatus.Visible = true;
            lblStatus.CssClass = "alert alert-danger d-block";
            lblStatus.Text = "There was an error processing your request. Please try again later.";
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "btnSubmit_Click", ex.Message);
        }
    }

}