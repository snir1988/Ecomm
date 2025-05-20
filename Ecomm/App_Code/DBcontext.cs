using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

public class DATA
{
    public class DbContext
    {
        public string Connstr { get; set; }
        public SqlConnection Conn { get; set; }

        public DbContext()
        {
            string ConnStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EcommDB.mdf;Integrated Security=True;Connect Timeout=30";
             Conn = new SqlConnection(ConnStr);
            Conn.Open();
        }

        public void Close()
        {
            Conn.Close();
        }
        public int ExecuteNonQuery(string Sql)
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            return Cmd.ExecuteNonQuery();
        }
        public DataTable Execute(string Sql)
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            SqlDataAdapter Da = new SqlDataAdapter();
            DataTable Dt = new DataTable();
            Da.SelectCommand = Cmd;
            Da.Fill(Dt);
            return Dt;
        }

        public object ExecuteScalar(string Sql) { 
        SqlCommand Cmd = new SqlCommand(Sql,Conn);
            return Cmd.ExecuteScalar();
        }


    }

}