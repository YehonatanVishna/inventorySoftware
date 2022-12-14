using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using WpfApp1;
using System.Net;

namespace InventoryServ
{
    /// <summary>
    /// Summary description for InventoryFuncs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InventoryFuncs : System.Web.Services.WebService
    {
        public String constr = "Server = '"+ Dns.GetHostName() +"\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ";
        [WebMethod]
        public DataTable GetInventoryUserDataTable(int userId, string email, string password)
        {
            var serv = new UserServ.UserDBServSoapClient();

            var isAllowed = serv.IsUserPermitted(new UserServ.User() { Password = password, Email = email });
            if (isAllowed)
            {
                Connection con = new Connection(constr);
                con.openCon();
                DataSet ds = con.GetDataSet("inventory", "Select * From inventory where OwnerUserId= " + userId);
                DataTable dt = ds.Tables[0];
                return dt;
            }
            return null;

        }
        [WebMethod]
        public bool changeInventoryRow(InventoryRow inventoryRow)
        {
            Connection con = new Connection(constr);
            con.openCon();
            bool a = con.ExequteNoneQury("update Inventory Set Name = N'" + inventoryRow.Name + "', Quantity = " + inventoryRow.Quantity.ToString() + ", NeededQuantity = " + inventoryRow.NeededQuantity.ToString() + ", Remarkes = N'"+ inventoryRow.Remarkes +"' Where ID = " + inventoryRow.ID.ToString() + " ;");
            con.CloseCon();
            if (a)
            {

            }
            return a;
        }
        [WebMethod]
        public bool DeleteInventoryRow(int id)
        {
            Connection con = new Connection(constr);
            con.openCon();
            bool a = con.ExequteNoneQury("Delete from Inventory where id = " + id + ";");
            con.CloseCon();
            return a;
        }
        [WebMethod]
        public int getNewItemId(int UserId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("inventory", "select * from inventory");
            DataRow dr = ds.Tables[0].NewRow();
            dr[4] = UserId;
            con.InsertDataRow(dr);
            con.openCon();
            DataSet dataSet = con.GetDataSet("inventory", "select * from Inventory where OwnerUserId =" + UserId.ToString() + ";");
            int lastIndex = dataSet.Tables["inventory"].Rows.Count -1;
            DataRow lastRow = dataSet.Tables["inventory"].Rows[lastIndex];
            con.CloseCon();
            return int.Parse(lastRow[0].ToString());
        }

    }
}
