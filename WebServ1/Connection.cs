using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//made by yehonatan vishna


namespace WpfApp1
{
    public class Connection
    {
        private SqlConnection con;
        private SqlDataReader reader;
        private DataTable tbl;
        private SqlDataAdapter adapter;
        private string tableName;
        private DataSet ds;
        public Connection(string conString)
        {
            con = new SqlConnection(conString);
        }
        /*
        public void CreateCon(string conString)
        {
            con = new SqlConnection(conString);
        }*/

        public void openCon()
        {
            //con = new SqlConnection(conString);
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }
        public SqlConnection GetCon() {
            return con;
        }
        public Boolean ExequteNoneQury(string noneQury) {
            //מוציא לפועל פעולת עדכון או מחיקה בשיטה מקושרת
            SqlCommand comd = new SqlCommand(noneQury, con);
            int a =comd.ExecuteNonQuery();
            comd.Dispose();
            return a > 0;
        }
        public SqlDataReader ExequteQury(string qury) {
            //מבצע שאילתת סלקט על מסד נתונים ומחזיר קורא
            SqlCommand comd = new SqlCommand(qury, con);
            reader = comd.ExecuteReader();
            return reader;
        }
        public DataTable GetDataTable() {
            //בהנחה שנוצר קורא, מחזיר טבלת מידע
            tbl = new DataTable();
            tbl.Load(reader);
            return tbl;
        }
        public DataTable GetDataTable(string qury)
        {
            //מקבל שאילתת סלקט ומחזיר טבלת מידע מתאימה
            SqlCommand comd = new SqlCommand(qury, con);
            reader = comd.ExecuteReader();
            tbl = new DataTable();
            tbl.Load(reader);
            return tbl;
        }

        public SqlDataAdapter GetAdapter(string qury) {
            //מקבל שאילתה ומחזיר מתאם מידע
            SqlCommand comd = new SqlCommand(qury, con);
            adapter = new SqlDataAdapter(comd);
            return adapter;
        }
        public DataSet GetDataSet(string tableName) {
            //מחזיר סט מידע בהנחה שמתאם כבר נוצר
            if (adapter != null)
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds, tableName);
                return ds;
            }
            else
            {
                return null;
            }
        }
        public DataSet GetDataSet(string tableN, string qury)
        {
            tableName = tableN;
            SqlCommand comd = new SqlCommand(qury, con);
            adapter = new SqlDataAdapter(comd);
            ds = new DataSet();
            adapter.Fill(ds, tableName);
            return ds;
        }
        public void InsertDataRow(DataRow dr) {
            if(ds != null)
            {
                ds.Tables[0].Rows.Add(dr);
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds, tableName);
        }
        public void InsertDataRow(DataRow dr, string tableN, string qury)
        {
            adapter = GetAdapter(qury);
            ds = GetDataSet(tableN);
            if (ds != null)
            {
                ds.Tables[0].Rows.Add(dr);
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds, tableName);
        }

        //made by yehonatan vishna



        public void Update(DataSet a) {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(a, tableName);
        }











    }
}
