using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Clients
/// </summary>
public class Clients
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }

    public static int InsertClients(SqlConnection conEQ, Clients cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into Clients (Title,Image,Status,AddedIp,AddedOn,AddedBy) values(@Title,@Image,@Status,@AddedIp,@AddedOn,@AddedBy)";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cat.Title;
                sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = cat.Image;
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
    public static int UpdateClients(SqlConnection conEQ, Clients cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Clients Set Title=@Title,Image=@Image,Status=@Status where Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cat.Title;
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
    public static List<Clients> GetAllFeaturedClients(SqlConnection conEQ)
    {
        List<Clients> result = new List<Clients>();
        try
        {
            string cmdText = "Select Top 3 * from Clients where Status='Active' and Featured='Yes'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Clients
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Title = Convert.ToString(dr["Title"]),
                              Image = Convert.ToString(dr["Image"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllClients", ex.Message);
        }

        return result;
    }
    public static List<Clients> GetAllClients(SqlConnection conEQ)
    {
        List<Clients> result = new List<Clients>();
        try
        {
            string cmdText = "Select * from Clients where Status='Active'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Clients
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Title = Convert.ToString(dr["Title"]),
                              Image = Convert.ToString(dr["Image"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllClients", ex.Message);
        }

        return result;
    }
    public static List<Clients> GetClientsByName(SqlConnection conEQ, string cat)
    {
        List<Clients> result = new List<Clients>();
        try
        {
            string cmdText = "Select * from Clients where Status!='Deleted' and Title=@Title";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Title", SqlDbType.NVarChar).Value = cat;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Clients
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Title = Convert.ToString(dr["Title"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetClientsByName", ex.Message);
        }

        return result;
    }
    public static decimal NoOfClients(SqlConnection conSP)
    {
        decimal x = 0;
        try
        {
            string query = " Select Count(Id) as cntA from Clients Where  Status != 'Deleted'";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "NoOfClients", ex.Message);
        }
        return x;
    }
    public static List<Clients> GetClientsById(SqlConnection conEQ, int id)
    {
        List<Clients> result = new List<Clients>();
        try
        {
            string cmdText = "Select * from Clients where Status=@Status and Id=@Id ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Clients
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Title = Convert.ToString(dr["Title"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetClients", ex.Message);
        }

        return result;
    }
    public static int DeleteClients(SqlConnection conEQ, Clients cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Clients Set Status=@Status,AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteClients", ex.Message);
        }

        return result;
    }
}