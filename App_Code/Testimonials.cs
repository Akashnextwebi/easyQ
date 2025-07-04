﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Testimonials
/// </summary>
public class Testimonials
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Details { get; set; }
    public string Designation { get; set; }
    public string Rating { get; set; }
    public DateTime AddedOn { get; set; }
    public string AddedIp { get; set; }
    public string AddedBy { get; set; }
    public string Status { get; set; }

    public static int InsertTestimonials(SqlConnection conEQ, Testimonials cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Insert Into Testimonials (Rating,Designation,UserName,Details,Status,AddedIp,AddedOn,AddedBy) values(@Rating,@Designation,@UserName,@Details,@Status,@AddedIp,@AddedOn,@AddedBy) ";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = cat.UserName;
                sqlCommand.Parameters.AddWithValue("@Details", SqlDbType.NVarChar).Value = cat.Details;
                sqlCommand.Parameters.AddWithValue("@Rating", SqlDbType.NVarChar).Value = cat.Rating;
                sqlCommand.Parameters.AddWithValue("@Designation", SqlDbType.NVarChar).Value = cat.Designation;
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
    public static int UpdateTestimonials(SqlConnection conEQ, Testimonials cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Testimonials Set Rating=@Rating,Designation=@Designation,UserName=@UserName,Details=@Details,Status=@Status where Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.NVarChar).Value = cat.Id;
                sqlCommand.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = cat.UserName;
                sqlCommand.Parameters.AddWithValue("@Rating", SqlDbType.NVarChar).Value = cat.Rating;
                sqlCommand.Parameters.AddWithValue("@Designation", SqlDbType.NVarChar).Value = cat.Designation;
                sqlCommand.Parameters.AddWithValue("@Details", SqlDbType.NVarChar).Value = cat.Details;
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
    public static List<Testimonials> GetAllTestimonialsList(SqlConnection conEQ)
    {
        List<Testimonials> result = new List<Testimonials>();
        try
        {
            string cmdText = "Select * from Testimonials where Status='Approved'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Testimonials
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              UserName = Convert.ToString(dr["UserName"]),
                              Rating = Convert.ToString(dr["Rating"]),
                              Designation = Convert.ToString(dr["Designation"]),
                              Details = Convert.ToString(dr["Details"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTestimonials", ex.Message);
        }

        return result;
    }
    public static List<Testimonials> GetAllTestimonials(SqlConnection conEQ)
    {
        List<Testimonials> result = new List<Testimonials>();
        try
        {
            string cmdText = "Select * from Testimonials where Status!='Deleted'";
            using (SqlCommand selectCommand = new SqlCommand(cmdText, conEQ))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Testimonials
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              UserName = Convert.ToString(dr["UserName"]),
                              Rating = Convert.ToString(dr["Rating"]),
                              Designation = Convert.ToString(dr["Designation"]),
                              Details = Convert.ToString(dr["Details"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetAllTestimonials", ex.Message);
        }

        return result;
    }
    public static List<Testimonials> GetTestimonials(SqlConnection conEQ, int id)
    {
        List<Testimonials> result = new List<Testimonials>();
        try
        {
            string cmdText = "Select * from Testimonials where Status!='Deleted' and Id=@Id";
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, conEQ))
            {
                sqlCommand.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                result = (from DataRow dr in dataTable.Rows
                          select new Testimonials
                          {
                              Id = Convert.ToInt32(Convert.ToString(dr["Id"])),
                              UserName = Convert.ToString(dr["UserName"]),
                              Details = Convert.ToString(dr["Details"]),
                              Designation = Convert.ToString(dr["Designation"]),
                              Rating = Convert.ToString(dr["Rating"]),
                              AddedOn = Convert.ToDateTime(Convert.ToString(dr["AddedOn"])),
                              AddedBy = Convert.ToString(dr["AddedBy"]),
                              AddedIp = Convert.ToString(dr["AddedIp"]),
                              Status = Convert.ToString(dr["Status"])
                          }).ToList();
            }

        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "GetTestimonials", ex.Message);
        }

        return result;
    }

    public static int DeleteTestimonials(SqlConnection conEQ, Testimonials cat)
    {
        int result = 0;
        try
        {
            string cmdText = "Update Testimonials Set Status=@Status,AddedOn=@AddedOn, AddedIp=@AddedIp Where Id=@Id ";
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
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "DeleteTestimonials", ex.Message);
        }

        return result;
    }
    public static decimal NoOfTestimonials(SqlConnection conZP)
    {
        decimal x = 0;
        try
        {
            string query = " Select Count(Id) as cntB from Testimonials Where  Status != 'Deleted'";
            SqlCommand cmd = new SqlCommand(query, conZP);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                decimal cntB = 0;
                decimal.TryParse(Convert.ToString(dt.Rows[0]["cntB"]), out cntB);
                x = cntB;
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "NoOfTestimonials", ex.Message);
        }
        return x;
    }

}