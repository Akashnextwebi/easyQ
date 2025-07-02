using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ResourceEnquiry
/// </summary>
public class ResourceEnquiry
{
    public int Id { get; set; }
    public string ResourceType { get; set; }
    public string ResourceTitle { get; set; }
    public string PageUrl { get; set; }
    public string Name { get; set; }
    public string EmailId { get; set; }
    public string Organization { get; set; }
    public string Phone { get; set; }
    public string Status { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public static int InsertResourceEnquiry(SqlConnection conAP, ResourceEnquiry model)
    {
        int result = 0;
        try
        {
            string query = "Insert Into ResourceEnquiry (ResourceType, ResourceTitle, PageUrl, Name, EmailId, Phone,Organization, Status, AddedOn, AddedIp, AddedBy) " +
                           "values (@ResourceType, @ResourceTitle, @PageUrl, @Name, @EmailId, @Phone,@Organization, @Status, @AddedOn, @AddedIp, @AddedBy)";
            using (SqlCommand cmd = new SqlCommand(query, conAP))
            {
                cmd.Parameters.AddWithValue("@ResourceType", SqlDbType.NVarChar).Value = model.ResourceType;
                cmd.Parameters.AddWithValue("@ResourceTitle", SqlDbType.NVarChar).Value = model.ResourceTitle;
                cmd.Parameters.AddWithValue("@Organization", SqlDbType.NVarChar).Value = model.Organization;
                cmd.Parameters.AddWithValue("@PageUrl", SqlDbType.NVarChar).Value = model.PageUrl;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = model.Name;
                cmd.Parameters.AddWithValue("@EmailId", SqlDbType.NVarChar).Value = model.EmailId;
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.NVarChar).Value = model.Phone;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = TimeStamps.UTCTime();
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                cmd.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = model.Name;
                conAP.Open();
                result = cmd.ExecuteNonQuery();
                conAP.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertResourceEnquiry", ex.Message);
        }
        return result;
    }
    public static int DeleteResourceEnquiry(SqlConnection _con, ResourceEnquiry model)
    {
        int result = 0;
        try
        {
            string query = "Update ResourceEnquiry Set Status=@Status Where Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = model.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteResourceEnquiry", ex.Message);
        }
        return result;
    }
    public static List<ResourceEnquiry> GetAllResourceEnquiry(SqlConnection conAP)
    {
        List<ResourceEnquiry> enquiries = new List<ResourceEnquiry>();
        try
        {
            string query = "select * from ResourceEnquiry where Status='Active' order by Id desc";
            using (SqlCommand cmd = new SqlCommand(query, conAP))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                enquiries = (from DataRow dr in dt.Rows
                             select new ResourceEnquiry()
                             {
                                 Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                 ResourceType = Convert.ToString(dr["ResourceType"]),
                                 ResourceTitle = Convert.ToString(dr["ResourceTitle"]),
                                 PageUrl = Convert.ToString(dr["PageUrl"]),
                                 Organization = Convert.ToString(dr["Organization"]),
                                 Name = Convert.ToString(dr["Name"]),
                                 EmailId = Convert.ToString(dr["EmailId"]),
                                 Phone = Convert.ToString(dr["Phone"]),
                                 AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                 AddedIp = Convert.ToString(dr["AddedIp"]),
                                 AddedBy = Convert.ToString(dr["AddedBy"])
                             }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllResourceEnquiry", ex.Message);
        }
        return enquiries;
    }
    public static decimal NoOfResourceEnquiry(SqlConnection conSP)
    {
        decimal x = 0;
        try
        {
            string query = " Select Count(Id) as cntR from ResourceEnquiry Where  Status != 'Deleted'";
            SqlCommand cmd = new SqlCommand(query, conSP);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                decimal cntR = 0;
                decimal.TryParse(Convert.ToString(dt.Rows[0]["cntR"]), out cntR);
                x = cntR;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "NoOfResourceEnquiry", ex.Message);
        }
        return x;
    }
}