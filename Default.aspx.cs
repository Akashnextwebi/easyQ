using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strArticles = "", strFAQs="", strClients="";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetAllArticles();
        GetAllFAQs();
        GetAllClients();
    }
    public void GetAllClients()
    {
        try
        {
            strClients = "";
            List<Clients> cas = Clients.GetAllClients(conEQ).ToList();
            int i = 0;
            foreach (Clients nb in cas)
            {
                strClients += @"<div class='swiper-slide'>
                  <div class='our-partner-item client-logo wow fadeInUp' data-wow-delay='0.2s'>
                    <img src='" + nb.Image+@"' alt='"+nb.Title+@"' />
                  </div>
                </div>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllClients", ex.Message);
        }
    }
    public void GetAllArticles()
    {
        try
        {
            strArticles = "";
            List<Articles> cas = Articles.GetAllFeaturedArticles(conEQ).OrderByDescending(s => Convert.ToDateTime(s.PostedOn)).ToList();
            int i = 0;
            foreach (Articles nb in cas)
            {
                strArticles += @"<div class='col-lg-4 col-md-6'> 
                    <div class='post-item wow fadeInUp'> 
                        <div class='post-featured-image'>
                            <a href='javascript:void(0);'>
                                <figure class='image-anime'>
                                    <img src='/" + nb.Image + @"' alt='" + nb.Article + @"' />
                                </figure>
                            </a>
                        </div> 
                        <div class='post-item-body'> 
                            <div class='post-item-content'>
                                    <span> " + Convert.ToDateTime(nb.PostedOn).ToString("dd-MMM-yyyy") + @"</span>
                                <h2 class='mt-2'>
                                    <a href='javascript:void(0);'>" + nb.Article + @"</a>
                                </h2>
                            </div>  
                            <div class='post-item-btn'>
                                <a href='javascript:void(0)' class='readmore-btn hidenId' data-id='" + nb.Id + @"' data-bs-toggle='modal' data-bs-target='#brochureModal'>Download Article</a>
                            </div> 
                        </div> 
                    </div> 
                </div>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllArticles", ex.Message);
        }
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
    public void GetAllFAQs()
    {
        try
        {
            strFAQs = "";
            List<FAQs> cas = FAQs.GetAllFAQs(conEQ).ToList();
            int i = 0;

            foreach (FAQs nb in cas)
            {
                string cls = i == 0 ? "" : "collapsed";
                string cls1 = i == 0 ? "show" : "";
                string expanded = i == 0 ? "true" : "false";

                strFAQs += @"<div class='accordion-item wow fadeInUp' data-wow-delay='0." + (i * 2) + @"s'>
    <h2 class='accordion-header' id='heading" + nb.Id + @"'>
        <button class='accordion-button " + cls + @"' type='button' data-bs-toggle='collapse' data-bs-target='#collapse" + nb.Id + @"' aria-expanded='" + expanded + @"' aria-controls='collapse" + nb.Id + @"'>
            " + (i + 1) + @". " + nb.Question + @"
        </button>
    </h2>
    <div id='collapse" + nb.Id + @"' class='accordion-collapse collapse " + cls1 + @"' aria-labelledby='heading" + nb.Id + @"' data-bs-parent='#accordion'>
        <div class='accordion-body'>
            <p>" + nb.Answer + @"</p>
        </div>
    </div>
</div>";

                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFAQs", ex.Message);
        }
    }

}