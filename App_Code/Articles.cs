using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Articles
/// </summary>
public class Articles
{
    public int Id { get; set; }
    public string Article { get; set; }
    public string Image { get; set; }
    public string Document { get; set; }
    public string Featured { get; set; }
    public DateTime AddedOn { get; set; }
    public String PostedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    public int TotalCount { get; set; }
    public int RowNumber { get; set; }

    public static int InsertArticles(SqlConnection conEQ, Articles cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into Articles (Article,Image,Document,Featured,Status,AddedIp,AddedOn,AddedBy,PostedOn) values(@Article,@Image,@Document,@Featured,@Status,@AddedIp,@AddedOn,@AddedBy,@PostedOn) ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Article", SqlDbType.NVarChar).Value = cat.Article;
                sqlCommand.Parameters.AddWithValue("@Document", SqlDbType.NVarChar).Value = cat.Document;
                sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = cat.Image;
                sqlCommand.Parameters.AddWithValue("@Featured", SqlDbType.NVarChar).Value = cat.Featured;
                sqlCommand.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                sqlCommand.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                sqlCommand.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
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
    public static int UpdateArticles(SqlConnection conEQ, Articles cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Articles Set Article=@Article,Document=@Document,PostedOn=@PostedOn,Featured=@Featured,Image=@Image,Status=@Status where Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@Article", SqlDbType.NVarChar).Value = cat.Article;
                sqlCommand.Parameters.AddWithValue("@Document", SqlDbType.NVarChar).Value = cat.Document;
                sqlCommand.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
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
    public static List<Articles> GetAllFeaturedArticles(SqlConnection conEQ)
    {
        List<Articles> result = new List<Articles>();
        try
        {
            string cmdText = "Select Top 3 * from Articles where Status='Active' and Featured='Yes'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Articles
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Article = Convert.ToString(dr["Article"]),
                              Image = Convert.ToString(dr["Image"]),
                              Document = Convert.ToString(dr["Document"]),
                              PostedOn = Convert.ToString(dr["PostedOn"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllArticles", ex.Message);
        }

        return result;
    }
    public static List<Articles> GetAllListArticles(SqlConnection conAP, int cPage)
    {
        List<Articles> articles = new List<Articles>();
        try
        {
            string qrury = @"Select top 6 * from 
                            (Select ROW_NUMBER() OVER(Order by  PostedOn desc) AS RowNo,
                            (select count(id) from Articles where status='Active') as TotalCount,
                            * from Articles
                            where Status='Active') x where RowNo >" + (6 * (cPage - 1));
            using (SqlCommand cmd = new SqlCommand(qrury, conAP))
            {
                // cmd.Parameters.AddWithValue("@cPage", SqlDbType.NVarChar).Value = cPage;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                articles = (from DataRow dr in dt.Rows
                         select new Articles()
                         {
                             Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                             RowNumber = Convert.ToInt32(Convert.ToString(dr["RowNo"])),
                             TotalCount = Convert.ToInt32(Convert.ToString(dr["TotalCount"])),
                             Article = Convert.ToString(dr["Article"]),
                             Image = Convert.ToString(dr["Image"]),
                             Document = Convert.ToString(dr["Document"]),
                             PostedOn = Convert.ToString(dr["PostedOn"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllListArticles", ex.Message);
        }
        return articles;
    }
    public static List<Articles> GetAllArticles(SqlConnection conEQ)
    {
        List<Articles> result = new List<Articles>();
        try
        {
            string cmdText = "Select * from Articles where Status='Active'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Articles
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Article = Convert.ToString(dr["Article"]),
                              Image = Convert.ToString(dr["Image"]),
                              Document = Convert.ToString(dr["Document"]),
                              PostedOn = Convert.ToString(dr["PostedOn"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllArticles", ex.Message);
        }

        return result;
    }
    public static List<Articles> GetArticlesByName(SqlConnection conEQ, string cat)
    {
        List<Articles> result = new List<Articles>();
        try
        {
            string cmdText = "Select * from Articles where Status!='Deleted' and Article=@Article";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Article", SqlDbType.NVarChar).Value = cat;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Articles
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Featured = Convert.ToString(dr["Featured"]),
                              PostedOn = Convert.ToString(dr["PostedOn"]),
                              Document = Convert.ToString(dr["Document"]),
                              Article = Convert.ToString(dr["Article"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetArticlesByName", ex.Message);
        }

        return result;
    }
    public static decimal NoOfArticles(SqlConnection conSP)
    {
        decimal x = 0;
        try
        {
            string query = " Select Count(Id) as cntA from Articles Where  Status != 'Deleted'";
            SqlCommand cmd = new SqlCommand(query, conSP);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                decimal cntA = 0;
                decimal.TryParse(Convert.ToString(dt.Rows[0]["cntA"]), out cntA);
                x = cntA;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "NoOfArticles", ex.Message);
        }
        return x;
    }
    public static List<Articles> GetArticlesById(SqlConnection conEQ, int id)
    {
        List<Articles> result = new List<Articles>();
        try
        {
            string cmdText = "Select * from Articles where Status=@Status and Id=@Id ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Articles
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Document = Convert.ToString(dr["Document"]),
                              PostedOn = Convert.ToString(dr["PostedOn"]),
                              Article = Convert.ToString(dr["Article"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetArticles", ex.Message);
        }

        return result;
    }
    public static int DeleteArticles(SqlConnection conEQ, Articles cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Articles Set Status=@Status,AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteArticles", ex.Message);
        }

        return result;
    }
}