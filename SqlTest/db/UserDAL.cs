using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlTest.models;
using System.Data;
using System.Xml.Linq;

namespace SqlTest.db
{
    public class UserDAL
    {
        private static SqlConnection sql = new SqlConnection(DALC.GetConnectionString());
        static public bool UpdateUser(string ID, string Name)
        {
            try
            {
                if (sql.State != ConnectionState.Open)
                {
                    sql.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE Users SET Name=@name WHERE ID=@ID", sql);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.ExecuteNonQuery();

                sql.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool CreateUser(string Name)
        {
            try
            {
                if (sql.State != ConnectionState.Open)
                {
                    sql.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Users(Name) VALUES(@Name);", sql);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.ExecuteNonQuery();

                sql.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool DeleteUser(string ID)
        {
            try
            {
                if (sql.State != ConnectionState.Open)
                {
                    sql.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE ID=@ID;", sql);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();

                sql.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public DataView GetUsers()
        {
            if (sql.State != ConnectionState.Open)
            {
                sql.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM Users;", sql);
            DataSet ds = new DataSet();
            da.Fill(ds);

            sql.Close();

            return ds.Tables[0].DefaultView;

        }

        static public DataView GetUserByID(int ID)
        {
            if (sql.State != ConnectionState.Open)
            {
                sql.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM Users WHERE ID={ID};", sql);
            DataSet ds = new DataSet();
            da.Fill(ds);

            sql.Close();

            return ds.Tables[0].DefaultView;

        }
    }
}
