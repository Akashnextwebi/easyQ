using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class template : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strTemplates = "";
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    [WebMethod(EnableSession = true)]
    public static List<Templates> GetAllTemplates(string pno)
    {
        SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
        List<Templates> templates = null;
        try
        {
            templates = Templates.GetAllListTemplates(conEQ, Convert.ToInt32(pno));
        }
        catch (Exception ex)
        {

            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTemplates", ex.Message);

        }
        return templates;
    }

    [WebMethod(EnableSession = true)]
    public static string downloadResource(string name, string phone, string email, string id, string org)
    {
        SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
        try
        {
            ResourceEnquiry RE = new ResourceEnquiry();
            List<Templates> ResName = Templates.GetTemplatesById(conEQ, Convert.ToInt32(id));
            RE.Name = name;
            RE.PageUrl = "";
            RE.Organization = org;
            RE.ResourceType = "Template";
            RE.ResourceTitle = ResName[0].Template;
            RE.EmailId = email;
            RE.Phone = phone;
            RE.Status = "Active";
            int result = ResourceEnquiry.InsertResourceEnquiry(conEQ, RE);
            if (result > 0)
            {
                return "Success | " + ResName[0].Document;
            }
            else
            {
                return "Error";
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DownloadBrachure", ex.Message);
            return "Error";
        }
    }
}