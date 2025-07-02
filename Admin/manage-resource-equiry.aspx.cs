using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_manage_resource_equiry : System.Web.UI.Page
{
    SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
    public string strRequests = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        GetAllResourceEnquiry();
    }
    public void GetAllResourceEnquiry()
    {
        try
        {
            List<ResourceEnquiry> lcs = ResourceEnquiry.GetAllResourceEnquiry(conEQ);
            int i = 0;
            foreach (ResourceEnquiry pro in lcs)
            {
                strRequests += @"<tr>   
                                <td>" + (i + 1) + @"</td>                                           
                                <td>" + pro.ResourceType + @"</td>
                                <td>" + pro.ResourceTitle + @"</td>
                                <td>" + pro.Name + @"</td>
                               <td><a href='CompanyEmail:" + pro.EmailId + "'>" + pro.EmailId + @"</a></td>
                                <td>" + pro.Phone + @"</td> 
                                <td>" + pro.AddedOn.ToString("dd/MM/yyyy") + @"</td> 
                                <td class='text-center'>
                                <a href='javascript:void(0);' class='bs-tooltip  fs-18 link-danger deleteItem' data-id='" + pro.Id + @"' data-bs-toggle='tooltip' data-placement='top' title='Delete'>
                                <i class='mdi mdi-trash-can-outline'></i></a></td>
                                </tr>";
                i++;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(Request.Url.PathAndQuery, "GetAllContactRequests", ex.Message);
        }
    }
    [WebMethod(EnableSession = true)]
    public static string Delete(string id)
    {
        string x = "";
        try
        {
            SqlConnection conEQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conEQ"].ConnectionString);
            if (CreateUser.CheckAccess(conEQ, "manage-resource-enquiry.aspx", "Delete", HttpContext.Current.Request.Cookies["eq_aid"].Value))
            {
                ResourceEnquiry BD = new ResourceEnquiry();
                BD.Id = Convert.ToInt32(id);
                int exec = ResourceEnquiry.DeleteResourceEnquiry(conEQ, BD);
                if (exec > 0)
                {
                    x = "Success";
                }
                else
                {
                    x = "W";
                }
            }
            else
            {
                x = "Permission";
            }

        }
        catch (Exception ex)
        {
            x = "W";
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "Delete", ex.Message);
        }
        return x;
    }
}