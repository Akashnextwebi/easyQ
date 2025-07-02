using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class BookADemo
{
    #region BookADemo
    public int Id { set; get; }
    public string Organization { get; set; }
    public string EmailId { get; set; }
    public string ContactNo { get; set; }
    public string UserName { get; set; }
    public string Country { get; set; }
    public DateTime AddedOn { set; get; }
    public string AddedIp { set; get; }
    public string Status { set; get; }
    public static List<BookADemo> GetAllBookADemo(SqlConnection conAP)
    {
        List<BookADemo> Blogs = new List<BookADemo>();
        try
        {
            string query = "select * from BookADemo where Status='Active' order by Id desc";
            using (SqlCommand cmd = new SqlCommand(query, conAP))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Blogs = (from DataRow dr in dt.Rows
                         select new BookADemo()
                         {
                             Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                             UserName = Convert.ToString(dr["UserName"]),
                             EmailId = Convert.ToString(dr["Email"]),
                             ContactNo = Convert.ToString(dr["Phone"]),
                             Country = Convert.ToString(dr["Country"]),
                             Organization = Convert.ToString(dr["Organization"]),
                             AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                             AddedIp = Convert.ToString(dr["AddedIP"]),
                         }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllBookADemo", ex.Message);
        }
        return Blogs;
    }
    public static int InserBookADemo(SqlConnection conAP, BookADemo Blog)
    {
        int result = 0;
        try
        {
            string query = "Insert Into BookADemo (Status,Country,UserName,Email,Phone,Organization,AddedOn,AddedIp) values(@Status,@Country,@UserName,@Email,@Phone,@Organization,@AddedOn,@AddedIp)";
            using (SqlCommand cmd = new SqlCommand(query, conAP))
            {
                cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = Blog.UserName;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = Blog.EmailId;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                cmd.Parameters.AddWithValue("@Phone", SqlDbType.NVarChar).Value = Blog.ContactNo;
                cmd.Parameters.AddWithValue("@Country", SqlDbType.NVarChar).Value = Blog.Country;
                cmd.Parameters.AddWithValue("@Organization", SqlDbType.NVarChar).Value = Blog.Organization;
                cmd.Parameters.AddWithValue("@AddedOn", SqlDbType.DateTime).Value = TimeStamps.UTCTime();
                cmd.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = CommonModel.IPAddress();
                conAP.Open();
                result = cmd.ExecuteNonQuery();
                conAP.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InserBookADemo", ex.Message);
        }
        return result;
    }
    public static int DeleteBookADemo(SqlConnection _con, BookADemo cat)
    {
        int result = 0;
        try
        {
            string query = "Update BookADemo Set Status=@Status Where Id=@Id";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                cmd.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                _con.Open();
                result = cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteBookADemo", ex.Message);
        }
        return result;
    }
    #endregion
}
