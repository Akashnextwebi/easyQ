using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class faq : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strFAQs = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetAllFAQs();
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

                strFAQs += @"<div class='accordion-item wow fadeInUp' data-wow-delay='0." + (i * 2) + @"s'>
    <h2 class='accordion-header' id='easyqHeading" + nb.Id + @"'>
        <button class='accordion-button " + cls + @"' type='button' data-bs-toggle='collapse' data-bs-target='#easyqCollapse" + nb.Id + @"' aria-expanded='" + (i == 0 ? "true" : "false") + @"' aria-controls='easyqCollapse" + nb.Id + @"'>
            " + (i + 1) + ". " + nb.Question + @"
        </button>
    </h2>
    <div id='easyqCollapse" + nb.Id + @"' class='accordion-collapse collapse " + cls1 + @"' aria-labelledby='easyqHeading" + nb.Id + @"' data-bs-parent='#accordionEasyQ'>
        <div class='accordion-body'>
            " + nb.Answer + @"
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