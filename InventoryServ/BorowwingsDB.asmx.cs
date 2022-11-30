using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;
using WpfApp1;
using System.Data;

namespace InventoryServ
{
    /// <summary>
    /// Summary description for BorowwingsDB
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BorowwingsDB : System.Web.Services.WebService
    {
        public static String constr = "Server = '" + Dns.GetHostName() + "\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ";
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int AddLending(int itemId, string lentForWho, DateTime whenBorowwed, float amountBorowwed, int userId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select * from BorrowedItems where 0>1");
            DataRow dr = ds.Tables[0].NewRow();
            dr["ItemId"] = itemId;
            dr["BorrowedBy"] = lentForWho;
            dr["When"] = whenBorowwed;
            dr["Quantity"] = amountBorowwed;
            dr["UserId"] = userId;
            con.InsertDataRow(dr);

            ds = con.GetDataSet("lands1", "select Top 1 * from BorrowedItems where ItemId =" + itemId.ToString() + "And BorrowedBy = N'"+ lentForWho.ToString() + "' And Quantity =" + amountBorowwed.ToString() + "  ORDER BY BorrowingId DESC");
            return int.Parse( ds.Tables[0].Rows[0]["BorrowingId"].ToString());
        }
        [WebMethod]
        public DataTable GetLandings(int UserId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select * from BorrowedItems where UserId=" + UserId.ToString() + ";");
            return ds.Tables["lands"];
            //List<Borrow> borrows = new List<Borrow>();
            //foreach(DataRow dr in ds.Tables["lands"].Rows)
            //{
            //    var bro = new Borrow();
            //    bro.ItemId = int.Parse(dr["ItemId"].ToString());
            //    bro.BorrowedBy = dr["BorrowedBy"].ToString();
            //    bro.When = DateTime.Parse(dr["When"].ToString());
            //    bro.Quantity = float.Parse(dr["Quantity"].ToString());
            //    bro.UserId = int.Parse(dr["UserId"].ToString());
            //    borrows.Add(bro);
            //}
            //var BorowDicts = new List<Dictionary<string, string>>();
            //foreach (Borrow b in borrows)
            //{
            //    Dictionary<string, string> BorowDict = new Dictionary<string, string>();
            //    BorowDict["ItemId"] = b.ItemId.ToString();
            //    BorowDict["BorrowedBy"] = b.BorrowedBy.ToString();
            //    BorowDict["When"] = b.When.ToString();
            //    BorowDict["Quantity"] = b.Quantity.ToString();
            //    BorowDict["UserId"] = b.UserId.ToString();
            //    BorowDicts.Add(BorowDict);
            //}
            //return BorowDicts;

        }
        [WebMethod]
        public string getName(int itemId) {
            var con = new Connection(BorowwingsDB.constr);
            con.openCon();
            var ds = con.GetDataSet("item name", "select Name from Inventory where ID = " + itemId + ";");
            con.CloseCon();
            return ds.Tables["item name"].Rows[0]["Name"].ToString();
        }
    }
}
