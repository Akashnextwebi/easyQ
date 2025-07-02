using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class clinical_evaluation : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strClients = "";
    protected void Page_Load(object sender, EventArgs e)
    {
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
              <img src='" + nb.Image + @"' alt='" + nb.Title + @"' />
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
}