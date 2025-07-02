using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class articiles : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strArticles = "";
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    [WebMethod(EnableSession = true)]
    public static List<Articles> GetAllArticles(string pno)
    {
        SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
        List<Articles> articles = null;
        try
        {
            articles = Articles.GetAllListArticles(conEQ, Convert.ToInt32(pno));
        }
        catch (Exception ex)
        {

            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllArticles", ex.Message);

        }
        return articles;
    }
    
    [WebMethod(EnableSession = true)]
    public static string downloadResource(string name, string phone, string email, string id, string org)
    {
        SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
        try
        {
            ResourceEnquiry RE = new ResourceEnquiry();
            List<Articles> ResName = Articles.GetArticlesById(conEQ, Convert.ToInt32(id));
            RE.Name = name;
            RE.PageUrl = "";
            RE.Organization = org;
            RE.ResourceType = "Article";
            RE.ResourceTitle = ResName[0].Article;
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