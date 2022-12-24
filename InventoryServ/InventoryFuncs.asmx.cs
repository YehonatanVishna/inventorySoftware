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
    /// a collection of functions to inteact with inventory items in db
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
        /// <summary>
        /// returns a DataTable Contaning all the inventory items that belongs to the user. For sequrity user needs to be authenticated with email and password.
        /// מחזיר טבלת מידע עם כל הפריטים ברשימת המלאי של המשתמש
        /// </summary>
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
        ///<summery>
        ///takes a motifyed InventoryRow item, the function applyes motifications to the item's coresponding row in db and returns wether the motifications were secsussfull.
        ///מקבל שורת מלאי שעברה שינויים ומכיל את השינויים לשורות המתאימות במסד הנתונים
        /// </summery>
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
        ///<summery>
        ///Takes an ItemId and deletes the coresponding item from db. for sequrity perpose, email and password are reqired.
        ///מקבל פרטי משתמש ומספר מזהה של שורת מלאי ומוחק את שורת המלאי בהנחה שהיא שייכת למשתמש שאת פרטיו הכניסו
        /// </summery>
        public bool DeleteInventoryRow(int id, string email, string password)
        {
            var serv = new UserServ.UserDBServSoapClient();

            var isAllowed = serv.GetFullUser(new UserServ.User() {Email= email, Password= password }).ID == GetOwnerID(id);
            if (isAllowed)
            {
                Connection con = new Connection(constr);
                con.openCon();
                bool a = con.ExequteNoneQury("Delete from Inventory where id = " + id + ";");
                con.CloseCon();
                return a;
            }
            else { return false; }
        }
        //returns the user that owns the item with the given itemId
        //מחזיר את מספר המשתמש שבבעלותו נמצא הפריט בעל מספר הפריט שהוכנס
        private int GetOwnerID(int ItemId)
        {
            Connection con = new Connection(constr);
            con.openCon();
            var ds = con.GetDataSet("Tbl", "Select OwnerUserId from Inventory where id =" + ItemId + ";");
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }
        [WebMethod]
        ///<summery>
        ///creates a new empty item, returns the new item's id. For sequrity, email and password are reqiured.
        ///יוצר פריט ריק חדש ברשימת המלאי של המשתמש שאת פריטיו הכניסו ומחזיר את המספר המזהה של הפריט שנוצר
        /// </summery>
        public int getNewItemId(int UserId, string email, string password)
        {
            var serv = new UserServ.UserDBServSoapClient();

            var isAllowed = serv.IsUserPermitted(new UserServ.User() { Password = password, Email = email });
            if (isAllowed)
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("inventory", "select * from inventory");
                DataRow dr = ds.Tables[0].NewRow();
                dr[4] = UserId;
                con.InsertDataRow(dr);
                con.openCon();
                DataSet dataSet = con.GetDataSet("inventory", "select * from Inventory where OwnerUserId =" + UserId.ToString() + ";");
                int lastIndex = dataSet.Tables["inventory"].Rows.Count - 1;
                DataRow lastRow = dataSet.Tables["inventory"].Rows[lastIndex];
                con.CloseCon();
                return int.Parse(lastRow[0].ToString());
            }
            else { return int.MinValue; }
        }

    }
}
