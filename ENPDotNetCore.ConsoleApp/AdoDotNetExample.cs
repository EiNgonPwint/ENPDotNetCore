﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace ENPDotNetCore.ConsoleApp
{
    internal class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "THURA",
            InitialCatalog = "ENPDotNetCore",//database name
            UserID = "sa",
            Password = "sasa@123"
        };  
        public void Read()
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection open");
            string query = "select * from Tbl_Blog;";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//new query (cmd)
            DataTable dt = new DataTable();//create table in sql
            adapter.Fill(dt);// when click execute, result comes into dt
            connection.Close();
            Console.WriteLine("Connection close");

            //dataset => datatable
            //datatable=>talblerow
            //tablerow=>tablecolumn
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("BLog Id =>" + dr["BlogId"]);
                Console.WriteLine("BLog Tilte =>" + dr["BlogTitle"]);
                Console.WriteLine("BLog Author =>" + dr["BlogAuthor"]);
                Console.WriteLine("BLog Content =>" + dr["BlogContent"]);
                Console.WriteLine("------------------------------");
            }
        }

        public void Create(string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection open");
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
            VALUES
           (@BlogTitle
           ,@BlogAuthor
           ,@BlogContent)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogTitle",title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", title);
            int result =cmd.ExecuteNonQuery();
            connection.Close();
            string message = result > 0 ? "Saving Successful" : "Saving Failed";
            Console.WriteLine(message);
        }
       
        public void Update (int id, string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection open");
            string query = @"UPDATE [dbo].[Tbl_Blog]
                SET [BlogTitle] = @BlogTitle
                ,[BlogAuthor] = @BlogAuthor
                ,[BlogContent] = @BlogContent
                 WHERE BLogId =@BlogId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogId",id);
            cmd.Parameters.AddWithValue("@BlogTitle", title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", title);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            string message = result > 0 ? "Updating Successful" : "Updating Failed";
            Console.WriteLine(message);
        }

        public void Delete (int id)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection open");
            string query = @"DELETE FROM [dbo].[Tbl_Blog]
            WHERE BlogId = @BlogId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogId", id);
            
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            string message = result > 0 ? "Deleting Successful" : "Deleting Failed";
            Console.WriteLine(message);
        }

        public void Edit(int id)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();
            Console.WriteLine("Connection open");
            string query = "select * from Tbl_Blog where BlogId = @BlogId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogId", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//new query (cmd)
            DataTable dt = new DataTable();//create table in sql
            adapter.Fill(dt);// when click execute, result comes into dt
            connection.Close();
            Console.WriteLine("Connection close");
            if(dt.Rows.Count == 0)
            {
                Console.WriteLine("No data found");
                return;
            }

            //dataset => datatable
            //datatable=>talblerow
            //tablerow=>tablecolumn
                DataRow dr = dt.Rows[0];
            
                Console.WriteLine("BLog Id =>" + dr["BlogId"]);
                Console.WriteLine("BLog Tilte =>" + dr["BlogTitle"]);
                Console.WriteLine("BLog Author =>" + dr["BlogAuthor"]);
                Console.WriteLine("BLog Content =>" + dr["BlogContent"]);
                Console.WriteLine("------------------------------");
            
        }
    }
}
