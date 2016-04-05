using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.IO;

namespace Login_Using_Gmail
{
    public class DALayer
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;Initial Catalog=GoogleLoginDemo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd = new SqlCommand();
        VALayer Vlaye = new VALayer();
        SqlDataReader sdr;
        public void Register(VALayer val)
        {
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Name", val.Name.ToString());
            cmd.Parameters.AddWithValue("@Dob", val.Dob);
            cmd.Parameters.AddWithValue("@pass", val.Password.ToString());
            cmd.Parameters.AddWithValue("@email", val.Email.ToString());
            cmd.CommandText = "insert into dbo.GoogleLogin (UName,DateOfBirth,Password,Email) values(@Name,@Dob,@pass,@email);";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Logins(VALayer val)
        {
            if ((val.Name != null) & (val.Password != null))
            {
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@pass", val.Password.ToString());
                cmd.Parameters.AddWithValue("@Name", val.Name.ToString());
                cmd.CommandText = "select UName from dbo.GoogleLogin where UName=@Name and Password=@pass;";
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string Name = sdr["UName"].ToString();
                    HttpContext.Current.Response.Redirect("WelcomeForm.aspx?Name=" + Name);
                }

            }
            else if(val.Email!=null)
            {
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@email", val.Email.ToString());
                cmd.CommandText = "select UName from dbo.GoogleLogin where Email=@email;";
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string Name = sdr["UName"].ToString();
                    HttpContext.Current.Response.Redirect("WelcomeForm.aspx?Name=" + Name);
                }
            }
            }
        }
    }