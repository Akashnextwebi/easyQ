using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Templates
/// </summary>
public class Templates
{
    public int Id { get; set; }
    public string Template { get; set; }
    public string Image { get; set; }
    public string Document { get; set; }
    public string PostedOn { get; set; }
    public string Featured { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }
    public int RowNumber { get; set; }
    public int TotalCount { get; set; }

    public static List<Templates> GetAllListTemplates(SqlConnection conAP, int cPage)
    {
        List<Templates> templates = new List<Templates>();
        try
        {
            string qrury = @"Select top 6 * from 
                            (Select ROW_NUMBER() OVER(Order by PostedOn desc) AS RowNo,
                            (select count(id) from Templates where status='Active') as TotalCount,
                            * from Templates
                            where Status='Active') x where RowNo >" + (6 * (cPage - 1));
            using (SqlCommand cmd = new SqlCommand(qrury, conAP))
            {
                // cmd.Parameters.AddWithValue("@cPage", SqlDbType.NVarChar).Value = cPage;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                templates = (from DataRow dr in dt.Rows
                            select new Templates()
                            {
                                Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                                RowNumber = Convert.ToInt32(Convert.ToString(dr["RowNo"])),
                                TotalCount = Convert.ToInt32(Convert.ToString(dr["TotalCount"])),
                                Template = Convert.ToString(dr["Template"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllListTemplates", ex.Message);
        }
        return templates;
    }

    public static int InsertTemplates(SqlConnection conEQ, Templates cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into Templates (Template,Image,Document,Featured,Status,AddedIp,AddedOn,AddedBy,PostedOn) values(@Template,@Image,@Document,@Featured,@Status,@AddedIp,@AddedOn,@AddedBy,@PostedOn) ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Template", SqlDbType.NVarChar).Value = cat.Template;
                sqlCommand.Parameters.AddWithValue("@Document", SqlDbType.NVarChar).Value = cat.Document;
                sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = cat.Image;
                sqlCommand.Parameters.AddWithValue("@Featured", SqlDbType.NVarChar).Value = cat.Featured;
                sqlCommand.Parameters.AddWithValue("@AddedIp", SqlDbType.NVarChar).Value = cat.AddedIp;
                sqlCommand.Parameters.AddWithValue("@AddedOn", SqlDbType.NVarChar).Value = cat.AddedOn;
                sqlCommand.Parameters.AddWithValue("@AddedBy", SqlDbType.NVarChar).Value = cat.AddedBy;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = cat.Status;
                sqlCommand.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
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
    public static int UpdateTemplates(SqlConnection conEQ, Templates cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Templates Set Template=@Template,Document=@Document,PostedOn=@PostedOn,Featured=@Featured,Image=@Image,Status=@Status where Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@Template", SqlDbType.NVarChar).Value = cat.Template;
                sqlCommand.Parameters.AddWithValue("@Document", SqlDbType.NVarChar).Value = cat.Document;
                sqlCommand.Parameters.AddWithValue("@Featured", SqlDbType.NVarChar).Value = cat.Featured;
                sqlCommand.Parameters.AddWithValue("@Image", SqlDbType.NVarChar).Value = cat.Image;
                sqlCommand.Parameters.AddWithValue("@PostedOn", SqlDbType.NVarChar).Value = cat.PostedOn;
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
    public static List<Templates> GetAllTemplates(SqlConnection conEQ)
    {
        List<Templates> result = new List<Templates>();
        try
        {
            string cmdText = "Select * from Templates where Status='Active'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Templates
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Template = Convert.ToString(dr["Template"]),
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTemplates", ex.Message);
        }

        return result;
    }
    public static List<Templates> GetTemplatesByName(SqlConnection conEQ, string cat)
    {
        List<Templates> result = new List<Templates>();
        try
        {
            string cmdText = "Select * from Templates where Status!='Deleted' and Template=@Template";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Template", SqlDbType.NVarChar).Value = cat;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Templates
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Featured = Convert.ToString(dr["Featured"]),
                              Document = Convert.ToString(dr["Document"]),
                              Template = Convert.ToString(dr["Template"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              PostedOn = Convert.ToString(dr["PostedOn"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTemplatesByName", ex.Message);
        }

        return result;
    }
    public static decimal NoOfTemplates(SqlConnection conSP)
    {
        decimal x = 0;
        try
        {
            string query = " Select Count(Id) as cntT from Templates Where  Status != 'Deleted'";
            SqlCommand cmd = new SqlCommand(query, conSP);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                decimal cntT = 0;
                decimal.TryParse(Convert.ToString(dt.Rows[0]["cntT"]), out cntT);
                x = cntT;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "NoOfTemplates", ex.Message);
        }
        return x;
    }
    public static List<Templates> GetTemplatesById(SqlConnection conEQ, int id)
    {
        List<Templates> result = new List<Templates>();
        try
        {
            string cmdText = "Select * from Templates where Status=@Status and Id=@Id ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = "Active";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Templates
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              Document = Convert.ToString(dr["Document"]),
                              Template = Convert.ToString(dr["Template"]),
                              Featured = Convert.ToString(dr["Featured"]),
                              Image = Convert.ToString(dr["Image"]),
                              PostedOn = Convert.ToString(dr["PostedOn"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTemplates", ex.Message);
        }

        return result;
    }
    public static int DeleteTemplates(SqlConnection conEQ, Templates cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Templates Set Status=@Status,AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteTemplates", ex.Message);
        }

        return result;
    }
}