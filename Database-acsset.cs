using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    class Database_acsset
    {
        SqlConnection sqlConnection;
        public Database_acsset()
        {
            string sql = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_BAN_HANG;Integrated Security=True";
            sqlConnection = new SqlConnection(sql);
        }
        public DataTable getalldata(string Sql)
        {
            sqlConnection.Open();
            try {
                SqlCommand sqlCommand = new SqlCommand(Sql, sqlConnection);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

                DataTable data = new DataTable();

                sqlData.Fill(data);

                sqlConnection.Close();
              
                return data;
            }
            catch (Exception ex) {
                sqlConnection.Close();
                return null;
            }
        }
        public bool insertdata (string sql)
        {
            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }
        }
        public bool updateData(string sql)
        {
            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }
        }
        public bool deleteData(string sql)
        {
            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                return false;
            }
        }
        public DataTable CheckData(string sql)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

            DataTable data = new DataTable();

            sqlData.Fill(data);

            sqlConnection.Close();

            if (data.Rows.Count > 0 )
            {
                return data;
            }
            else
            {
                return null;
            }
            
        }
    }
}

