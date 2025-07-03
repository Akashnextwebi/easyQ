using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Webinars
/// </summary>
public class Webinars
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public string ShortDesc { get; set; }
    public string YoutubeLink { get; set; }
    public string Featured { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    public int RowNumber { get; set; }
    public int TotalCount { get; set; }


    public static List<Webinars> GetAllListWebinars(SqlConnection conAP, int cPage)
    {
        List<Webinars> webinars = new List<Webinars>();
        try
        {
            string qrury = @"Select top 6 * from 
                            (Select ROW_NUMBER() OVER(Order by AddedOn desc) AS RowNo,
                            (select count(id) from Webinars where status='Active') as TotalCount,
                            * from Webinars
                            where Status='Active') x where RowNo >" + (6 * (cPage - 1));
            using (SqlCommand cmd = new SqlCommand(qrury, conAP))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                webinars = (from DataRow dr in dt.Rows
                            select new Webinars()
                            {
                                Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                RowNumber = Convert.ToInt32(Convert.ToString(dr["RowNo"])),
                                TotalCount = Convert.ToInt32(Convert.ToString(dr["TotalCount"])),
                                Title = Convert.ToString(dr["Title"]),
                                Image = Convert.ToString(dr["Image"]),
                                ShortDesc = Convert.ToString(dr["ShortDesc"]),
                                YoutubeLink = Convert.ToString(dr["YoutubeLink"]),
                                Featured = Convert.ToString(dr["Featured"]),
                                AddedIp = Convert.ToString(dr["AddedIp"]),
                                AddedBy = Convert.ToString(dr["AddedBy"]),
                                AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                                Status = Convert.ToString(dr["Status"])
                            }).ToList();
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllListWebinars", ex.Message);
        }
        return webinars;
    }

    public static int InsertWebinars(SqlConnection conEQ, Webinars cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into Webinars (Title,Image,ShortDesc,Featured,YoutubeLink,Status,AddedIp,AddedOn,AddedBy) values(@Title,@Image,@ShortDesc,@Featured,@YoutubeLink,@Status,@AddedIp,@AddedOn,@AddedBy) ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cat.Title;
                sqlCommand.Parameters.AddWithValue("@ShortDesc", SqlDbType.NVarChar).Value = cat.ShortDesc;
                sqlCommand.Parameters.AddWithValue("@YoutubeLink", SqlDbType.NVarChar).Value = cat.YoutubeLink;
                sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = cat.Image;
                sqlCommand.Parameters.AddWithValue("@Featured", SqlDbType.NVarChar).Value = cat.Featured;
                sqlCommand.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                sqlCommand.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                sqlCommand.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;
                conEQ.Open();
                result = sqlCommand.ExecuteNonQuery();
                conEQ.Close();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "InsertNoticeBoard", ex.Message);
        }

        return result;
    }
    public static int UpdateWebinars(SqlConnection conEQ, Webinars cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Webinars Set Title=@Title,YoutubeLink=@YoutubeLink,ShortDesc=@ShortDesc,Featured=@Featured,Image=@Image,Status=@Status where Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cat.Title;
                sqlCommand.Parameters.AddWithValue("@YoutubeLink", SqlDbType.NVarChar).Value = cat.YoutubeLink;
                sqlCommand.Parameters.AddWithValue("@ShortDesc", SqlDbType.NVarChar).Value = cat.ShortDesc;
                sqlCommand.Parameters.AddWithValue("@Featured", SqlDbType.NVarChar).Value = cat.Featured;
                sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = cat.Image;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;
                conEQ.Open();
                result = sqlCommand.ExecuteNonQuery();
                conEQ.Close();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "UpdateNoticeBoard", ex.Message);
        }

        return result;
    }
    public static List<Webinars> GetAllWebinars(SqlConnection conEQ)
    {
        List<Webinars> result = new List<Webinars>();
        try
        {
            string cmdText = "Select * from Webinars where Status='Active'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Webinars
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Title = Convert.ToString(dr["Title"]),
                              Image = Convert.ToString(dr["Image"]),
                              ShortDesc = Convert.ToString(dr["ShortDesc"]),
                              YoutubeLink = Convert.ToString(dr["YoutubeLink"]),
                              Featured = Convert.ToString(dr["Featured"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllWebinars", ex.Message);
        }

        return result;
    }
    public static List<Webinars> GetWebinarsByName(SqlConnection conEQ, string cat)
    {
        List<Webinars> result = new List<Webinars>();
        try
        {
            string cmdText = "Select * from Webinars where Status!='Deleted' and Title=@Title";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cat;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Webinars
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Featured = Convert.ToString(dr["Featured"]),
                              ShortDesc = Convert.ToString(dr["ShortDesc"]),
                              YoutubeLink = Convert.ToString(dr["YoutubeLink"]),
                              Title = Convert.ToString(dr["Title"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetWebinarsByName", ex.Message);
        }

        return result;
    }
    public static decimal NoOfWebinars(SqlConnection conEQ)
    {
        decimal x = 0;
        try
        {
            string query = " Select Count(Id) as cntW from Webinars Where  Status != 'Deleted'";
            SqlCommand cmd = new SqlCommand(query, conEQ);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                decimal cntW = 0;
                decimal.TryParse(Convert.ToString(dt.Rows[0]["cntW"]), out cntW);
                x = cntW;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "NoOfWebinars", ex.Message);
        }
        return x;
    }
    public static List<Webinars> GetWebinarsById(SqlConnection conEQ, int id)
    {
        List<Webinars> result = new List<Webinars>();
        try
        {
            string cmdText = "Select * from Webinars where Status=@Status and Id=@Id ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Webinars
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              YoutubeLink = Convert.ToString(dr["YoutubeLink"]),
                              ShortDesc = Convert.ToString(dr["ShortDesc"]),
                              Title = Convert.ToString(dr["Title"]),
                              Featured = Convert.ToString(dr["Featured"]),
                              Image = Convert.ToString(dr["Image"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetWebinars", ex.Message);
        }

        return result;
    }
    public static int DeleteWebinars(SqlConnection conEQ, Webinars cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Webinars Set Status=@Status,AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Deleted";
                sqlCommand.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                sqlCommand.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                conEQ.Open();
                result = sqlCommand.ExecuteNonQuery();
                conEQ.Close();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteWebinars", ex.Message);
        }

        return result;
    }
}