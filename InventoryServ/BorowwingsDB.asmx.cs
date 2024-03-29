﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net;
using WpfApp1;
using System.Data;
using InventoryServ;

namespace InventoryServ
{
    /// <summary>
    ///contains a few methods to interact with all active landings
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BorowwingsDB : System.Web.Services.WebService
    {
        public static String constr = "Server = '" + Dns.GetHostName() + "\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ";
        /// <summary>
        /// calculates the amount of items borrowed of a given item id
        /// מחשב את כמות הפריטים המושאלים מעצם בעל מספר מזהה נתון לפי סכימת השאלותיו בטבלת ההשאלות
        /// </summary>
        [WebMethod]
        public float CalcAmountOut(int itemId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select Quantity from BorrowedItems where ItemId=" + itemId.ToString() + ";");
            float amount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                amount += float.Parse(dr[0].ToString());
            }
            return amount;
        }
        [WebMethod]
        ///<summary>
        ///take an item id and updates this item amount out in db according to sum of his landings
        ///מעדכן את כמות הפריטים המושאלים מעצם מסויים ברשומה שלו במסד הנתונים לפי סכימת השאלותיו בטבלת ההשאלות
        ///</summary>
        public bool UpdateAmountOut(int itemId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select Quantity from BorrowedItems where ItemId=" + itemId.ToString() + ";");
            float amount = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                amount += float.Parse(dr[0].ToString());
            }
            con.openCon();
            var s = "Update Inventory Set AmountOut = " + amount.ToString() + " where ID = " + itemId.ToString() + ";";
            bool a = con.ExequteNoneQury(s);
            con.CloseCon();
            return a;
        }
        [WebMethod]
        ///<summary>
        ///update user's item's amount out in db acoording to each item's landings in db.
        ///מעדכן את כמות הפריטים המושאלים מכל פריט ברשימת המלאי של משתמש בעל מספר זיהוי נתון לפי סכימת השאלותיו של כל פריט בטבלת ההשאלות
        ///</summary>
        public bool UpdateUserAmountOut(int UserId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("Items", "select ID from Inventory where OwnerUserId=" + UserId.ToString() + ";");
            bool isOk = true;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                isOk = isOk && UpdateAmountOut(int.Parse(dr["ID"].ToString()));
            }
            return isOk;
        }
        [WebMethod]
        ///<summary>
        ///adds landing with given properties and adds it to db
        ///מוסיף השאלה בעלת התכונות המתקבלות מהמשתמש למסד הנתונים
        ///</summary>
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
            try
            {
                ds = con.GetDataSet("lands1", "select Top 1 * from BorrowedItems where ItemId =" + itemId.ToString() + "And BorrowedBy = N'" + lentForWho.ToString() + "' And Quantity =" + amountBorowwed.ToString() + "  ORDER BY BorrowingId DESC");

                int id = int.Parse(ds.Tables[0].Rows[0]["BorrowingId"].ToString());
                return id;
            }
            catch
            {
                return -1;
            }

        }
        [WebMethod]
        ///<summary>
        ///returns datatable of all of the user's active landings
        ///מחזיר טבלת מידע עם כל ההשאלות הפעילות של המשוייכות למשתמש
        ///</summary>
        public DataTable GetLandings(int UserId)
        {
            Connection con = new Connection(constr);
            DataSet ds = con.GetDataSet("lands", "select * from BorrowedItems where UserId=" + UserId.ToString() + ";");
            return ds.Tables["lands"];

        }
        [WebMethod]
        ///<summary>
        ///returns a item with a given item id name in db
        ///מחזיר את שמו של הפריט מרשימת המלאי בעל מספר מזהה נתון
        ///</summary>
        public string getName(int itemId) {
            var con = new Connection(BorowwingsDB.constr);
            con.openCon();
            var ds = con.GetDataSet("item name", "select Name from Inventory where ID = " + itemId + ";");
            con.CloseCon();
            return ds.Tables["item name"].Rows[0]["Name"].ToString();
        }
        //מחזיר את מספר המשתמש שבבעלותו נמצא הפריט בעל מספר הפריט שהוכנס
        public int GetOwnerID(int ItemId)
        {
            Connection con = new Connection(constr);
            con.openCon();
            var ds = con.GetDataSet("Tbl", "Select OwnerUserId from Inventory where id =" + ItemId + ";");
            return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        }
        [WebMethod]
        ///<summary>
        ///deletets a lending, returns wethwe the operation secusseded
        ///מוחק השאלה מחזיר האם הפעולה הצליחה
        /// </summary>
        public bool DeleteLanding(Borrow borrow, string email, string password)
        {
            var s = new UserServ.UserDBServSoapClient();
            var FullUser = s.GetFullUser(new UserServ.User() { Email = email, Password = password });
            if(FullUser.ID == GetOwnerID(borrow.ItemId))
            {
                var con = new Connection(constr);
                con.openCon();
                var qury = "DELETE FROM BorrowedItems WHERE BorrowingId = " + borrow.BorrowingId + ";";
                bool isok = con.ExequteNoneQury(qury);
                if (isok) {
                    UpdateAmountOut(borrow.ItemId);
                    return isok;
                }
                return isok;
            }
            else { return false; }
        }
        [WebMethod]
        ///<summary>
        ///updates a landing ditailes
        ///מעדכן את פרטי ההשאלה מחזיר האם העדכון עבד
        /// </summary>
        public bool updateBorrow(Borrow oldborrow, Borrow newBorrow, string email, string password)
        {
            var s = new UserServ.UserDBServSoapClient();
            var FullUser = s.GetFullUser(new UserServ.User() { Email = email, Password = password });
            if (FullUser.ID == GetOwnerID(oldborrow.ItemId))
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("lands", "select * from BorrowedItems where BorrowingId =" + oldborrow.BorrowingId + ";");
                DataRow dr = ds.Tables[0].Rows[0];
                dr["ItemId"] = newBorrow.ItemId;
                dr["BorrowedBy"] = newBorrow.BorrowedBy;
                dr["When"] = newBorrow.When;
                dr["Quantity"] = newBorrow.Quantity;
                dr["UserId"] = newBorrow.UserId;
                con.Update(ds);
                return true;
            }
            else { return false; }
        }
        [WebMethod]
        public void updateBorrowTest()
        {
            updateBorrow(new Borrow() { ItemId = 368, UserId = 20, BorrowingId = 28 }, new Borrow() { ItemId = 368, UserId = 20, BorrowedBy = "meme", BorrowingId = 28, Quantity = 99, When = DateTime.Now }, "yv@v.com                      ", "123456789           ");
        }
    }
}
