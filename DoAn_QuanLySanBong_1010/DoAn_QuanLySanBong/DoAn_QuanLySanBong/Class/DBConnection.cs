using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DoAn_QuanLySanBong.Class
{
    class DBConnection
    {
        public static string stringConnection;
        private SqlConnection Conn;
        public DBConnection(string user, string pws, string host, string databaseName)
        {
            //kết nối ip
            //stringConnection = @"Data Source=" + host + ";Initial Catalog=" + databaseName + ";User Id=" + user + ";password=" + pws + ";";
            stringConnection = @"Data Source= SHINICHIKUTIEN;Initial Catalog= DB_QLSANBONG;User Id = sa;password=123;";      
        }
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public DBConnection()
        {
            Conn = new SqlConnection(stringConnection);
        }
        public void Open()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }
        public void Close()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }
        public int GetNonQuery(string query)
        {
            int kq;
            Open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            kq = cmd.ExecuteNonQuery();
            return kq;
        }
        public DataTable GetDataTable(string query)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            da.Fill(ds);
            return ds;
        }
        public object GetScalar(string query)
        {
            object kq;
            Open();
            SqlCommand cmd = new SqlCommand(query, Conn);
            kq = (object)cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public int UpdateTable(DataTable dtnew, string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            int kq = da.Update(dtnew);
            return kq;
        }
    }
}
