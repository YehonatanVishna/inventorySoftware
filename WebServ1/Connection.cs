using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Represents a connection to a SQL database.
/// </summary>
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
        //initelize connection
        public Connection(string conString)
        {
            con = new SqlConnection(conString);
        }
        //opens connections
        public void openCon()
        {
            con.Open();
        }
        //colses connection
        public void CloseCon()
        {
            con.Close();
        }
        //returns connection
        public SqlConnection GetCon()
        {
            return con;
        }
        //exequte a qury in a connected method
        public Boolean ExequteNoneQury(string noneQury)
        {
            SqlCommand comd = new SqlCommand(noneQury, con);
            int a = comd.ExecuteNonQuery();
            comd.Dispose();
            return a > 0;
        }
        // Executes a select query on the connected database and returns a reader.
        public SqlDataReader ExequteQury(string qury)
        {
            SqlCommand comd = new SqlCommand(qury, con);
            reader = comd.ExecuteReader();
            return reader;
        }
        //returns a datatable loded by pre created reader
        public DataTable GetDataTable()
        {
            tbl = new DataTable();
            tbl.Load(reader);
            return tbl;
        }
        //recives a select qury and returns datatable
        public DataTable GetDataTable(string qury)
        {
            SqlCommand comd = new SqlCommand(qury, con);
            reader = comd.ExecuteReader();
            tbl = new DataTable();
            tbl.Load(reader);
            return tbl;
        }
        //recives a select qury and returns SqlDataAdapter
        public SqlDataAdapter GetAdapter(string qury)
        {
            SqlCommand comd = new SqlCommand(qury, con);
            adapter = new SqlDataAdapter(comd);
            return adapter;
        }
        //Returns DataSet, asumming SqlDataAdapter has alredy been created
        public DataSet GetDataSet(string tableName)
        {
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
        //takes a select qury, and retuns the qury's respons table
        public DataSet GetDataSet(string tableN, string qury)
        {
            tableName = tableN;
            SqlCommand comd = new SqlCommand(qury, con);
            adapter = new SqlDataAdapter(comd);
            ds = new DataSet();
            adapter.Fill(ds, tableName);
            return ds;
        }
        //takes a DataRow and inserts it into the coresponding table, assuming dataSet has alredy been previusly created
        public void InsertDataRow(DataRow dr)
        {
            if (ds != null)
            {
                ds.Tables[0].Rows.Add(dr);
            }
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds, tableName);
        }
        //takes a motifyed DataSet, and applys motifications to db
        public void Update(DataSet a)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(a, tableName);
        }
    }
}
