using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;

public partial class Admin_dashboard : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string Strusername = "", StrContact = "", strNoOfArticles = "", strNoOfTemplates = "", strNoOfWebinars = "", strNoOfResourceRequests = "";
    protected void Page_Load(object sender, EventArgs e)
    {//check if admin login is valid
        if (Request.Cookies["eq_aid"] == null)
        {
            Response.Redirect("Default.aspx", false);
        }
        BindUserName();
        NoOfResourceRequets();
        NoOfArticles();
        NoOfTemplates();
        NoOfWebinars();
        GetTo10ConctactReq();

    }

    public void BindUserName()
    {
        try
        {
            Strusername = CreateUser.GetLoggedUserName(conEQ, Request.Cookies["eq_aid"].Value);
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindUserName", ex.Message);
        }
    }
    private void NoOfResourceRequets()
    {
        decimal cntR = ResourceEnquiry.NoOfResourceEnquiry(conEQ);
        strNoOfResourceRequests = cntR.ToString();
    }
    private void NoOfArticles()
    {
        decimal cntA = Articles.NoOfArticles(conEQ);
        strNoOfArticles = cntA.ToString();
    }

    private void NoOfTemplates()
    {
        decimal cntT = Templates.NoOfTemplates(conEQ);
        strNoOfTemplates = cntT.ToString();
    }

    private void NoOfWebinars()
    {
        decimal cntW = Webinars.NoOfWebinars(conEQ);
        strNoOfWebinars = cntW.ToString();
    }
    public void GetTo10ConctactReq()
    {
        try
        {
            List<ContactUs> lcs = ContactUs.GetTop10ContactUs(conEQ);
            int i = 0;
            foreach (ContactUs pro in lcs)
            {
                StrContact += @"<tr>   
                                <td>" + (i + 1) + @"</td>                                           
                                <td>" + pro.UserName + @"</td>
                               <td><a href='CompanyEmail:" + pro.EmailId + "'>" + pro.EmailId + @"</a></td>
                                <td>" + pro.ContactNo + @"</td> 
                                <td><a href='javascript:void(0);' data-bs-toggle='modal' data-bs-target='#fadeInRightModal' class='btn btn-sm btn-secondary badge-gradient-secondary btnmsg' data-id=" + pro.Id + @" data-name=" + pro.UserName + @">View Message</a></td>
                                <td>" + pro.AddedOn.ToString("dd/MM/yyyy") + @"</td> 
                                </tr>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "GetTo10ConctactReq", ex.Message);
        }
    }
    [WebMethod(EnableSession = true)]
    public static string GetMessage(string id)
    {
        var message = "";
        try
        {
            SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
            message = ContactUs.GetMessageById(conEQ, id);
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetMessage", ex.Message);
        }
        return message;
    }
}