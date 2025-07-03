using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class samd_and_ai_deviciess : System.Web.UI.Page
{
     SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strClients = "", strTestimonials="";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetAllClients();
        GetAllTestimonials();
    }
    public void GetAllTestimonials()
    {
        try
        {
            strTestimonials = "";
            List<Testimonials> cas = Testimonials.GetAllTestimonials(conEQ).ToList();

            foreach (Testimonials item in cas)
            {
                string initials = "";
                string[] nameParts = item.UserName.Split(' ');
                if (nameParts.Length == 1)
                {
                    initials = nameParts[0][0].ToString().ToUpper();
                }
                else
                {
                    initials = nameParts[0][0].ToString().ToUpper() + nameParts[1][0].ToString().ToUpper();
                }
                int rating = 0;
                int.TryParse(item.Rating, out rating);
                string starHtml = "";
                for (int i = 0; i < rating; i++)
                {
                    starHtml += "<i class='fas fa-star star'></i>";
                }
                strTestimonials +=
                    "<div class='swiper-slide'>" +
                    "<div class='testimonial-card'>" +
                            "<div class='star-rating'>" +
                                starHtml +
                            "</div>" +
                            "<p class='testimonial-quote'>" +
                                item.Details +
                            "</p>" +
                            "<div class='testimonial-author'>" +
                                "<div class='author-image'>" + initials + "</div>" +
                                "<div class='author-info'>" +
                                    "<h5>" + item.UserName + "</h5>" +
                                    "<p>" + item.Designation + "</p>" +
                                "</div>" +
                            "</div>" +
                        "</div>" +
                    "</div>";
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTestimonials", ex.Message);
        }
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