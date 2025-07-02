using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FAQs
/// </summary>
public class FAQs
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string DisplayOrder { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }

    public static int InsertFAQs(SqlConnection conEQ, FAQs cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into FAQs (Answer,Question,DisplayOrder,Status,AddedIp,AddedOn,AddedBy) values(@Answer,@Question,@DisplayOrder,@Status,@AddedIp,@AddedOn,@AddedBy) ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Answer", SqlDbType.NVarChar).Value = cat.Answer;
                sqlCommand.Parameters.AddWithValue("@Question", SqlDbType.NVarChar).Value = cat.Question;
                sqlCommand.Parameters.AddWithValue("@DisplayOrder", SqlDbType.NVarChar).Value = cat.DisplayOrder;
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
    public static int UpdateFAQs(SqlConnection conEQ, FAQs cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update FAQs Set Answer=@Answer,Question=@Question,DisplayOrder=@DisplayOrder,Status=@Status where Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@Question", SqlDbType.NVarChar).Value = cat.Question;
                sqlCommand.Parameters.AddWithValue("@DisplayOrder", SqlDbType.NVarChar).Value = cat.DisplayOrder;
                sqlCommand.Parameters.AddWithValue("@Answer", SqlDbType.NVarChar).Value = cat.Answer;
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
    public static List<FAQs> GetAllFAQs(SqlConnection conEQ)
    {
        List<FAQs> result = new List<FAQs>();
        try
        {
            string cmdText = "SELECT * FROM FAQs WHERE Status='Active' ORDER BY TRY_CAST(DisplayOrder AS INT)";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new FAQs
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Answer = Convert.ToString(dr["Answer"]),
                              Question = Convert.ToString(dr["Question"]),
                              DisplayOrder = Convert.ToString(dr["DisplayOrder"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllFAQs", ex.Message);
        }

        return result;
    }
    public static List<FAQs> GetFAQs(SqlConnection conEQ, int id)
    {
        List<FAQs> result = new List<FAQs>();
        try
        {
            string cmdText = "Select * from FAQs where Status=@Status and Id=@Id ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new FAQs
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Answer = Convert.ToString(dr["Answer"]),
                              DisplayOrder = Convert.ToString(dr["DisplayOrder"]),
                              Question = Convert.ToString(dr["Question"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetFAQs", ex.Message);
        }

        return result;
    }


    public static int DeleteFAQs(SqlConnection conEQ, FAQs cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update FAQs Set Status=@Status,AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteFAQs", ex.Message);
        }

        return result;
    }
}