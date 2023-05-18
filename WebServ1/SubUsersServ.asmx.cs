using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;


namespace WebServ1
{
    /// <summary>
    /// Summary description for SubUsersServ
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SubUsersServ : System.Web.Services.WebService
    {
        //יוצר את המחרוזת חיבור שסביר שבשימוש לפי ברירת המחדל של אס קיו אל סרוור
        //creates the tipical constring according to sqlserver express defaults
        public String constr = "Server = '" + Dns.GetHostName() + "\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ";
        [WebMethod]
        ///<summary>
        ///מקבל עצם משתמש תחתון ומכניס משתמש מתאים למסד הנתונים
        ///creates a new sub user in db from a subuser object
        /// </summary>
        public int createSubUser(SubUser subUser, User UpperUser)
        {
            var usdb = new UserDBServ();
            if (usdb.IsUserPermitted(UpperUser))
            {
                var con = new Connection(constr);
                con.openCon();
                String nqury = "Insert into SubUsers (BelongsToUpperUser, FName, LName, Role, Email, Password, UserName) Values (" + subUser.BelongsToUpperUser + ", '" + subUser.FName + "', '" + subUser.LName + "', '" + subUser.Role + "', '" + subUser.Email + "', '" + subUser.Password + "', '" + subUser.UserName + "');";
                bool isok = con.ExequteNoneQury(nqury);
                con.CloseCon();
                var ds = con.GetDataSet("usr", "select * from SubUsers where BelongsToUpperUser = " + subUser.BelongsToUpperUser + ";");
                var id = int.Parse(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["ID"].ToString());
                return id;
            }
            else
            {
                return -1;
            }
        }
        [WebMethod]
        ///<summary>
        ///מקבל משתמש עליון ומחזיר את המשתמשים התחתונים המשוייכים אליו
        ///takes a upper user's ditailes and returns a datatable of all his subusers
        /// </summary>
        public DataTable getYourSubUsers(User UpperUser)
        {
            var usdb = new UserDBServ();
            if (usdb.IsUserPermitted(UpperUser))
            {
                var con = new Connection(constr);
                con.openCon();
                var sequreUser = usdb.GetFullUser(UpperUser);
                var ds = con.GetDataSet("subs", "Select * from SubUsers  where BelongsToUpperUser = " + sequreUser.ID + ";");
                return ds.Tables[0];
            }
            return null;
        }
        [WebMethod]
        ///<summary>
        ///מעדכן את פרטי משתמש קיים
        ///updates a subusers
        /// </summary>
        public bool updateSub(SubUser subUser, User user)
        {
            var usdb = new UserDBServ();
            if (usdb.IsUserPermitted(user))
            {
                var con = new Connection(constr);
                con.openCon();
                var ds = con.GetDataSet("p", "Select * from SubUsers where ID = " + subUser.Id + ";");
                var sequreUser = usdb.GetFullUser(user);
                if (int.Parse(ds.Tables[0].Rows[0]["BelongsToUpperUser"].ToString()) == sequreUser.ID)
                {
                    if (doesUserNameAlredyInUse(subUser.Id, subUser.UserName))
                    {
                        throw new InvalidOperationException("the user "+ subUser.UserName +" name is alredy in use, use a diffrent one");
                    }
                    ds.Tables[0].Rows[0]["BelongsToUpperUser"] = subUser.BelongsToUpperUser;
                    ds.Tables[0].Rows[0]["FName"] = subUser.FName;
                    ds.Tables[0].Rows[0]["LName"] = subUser.LName;
                    ds.Tables[0].Rows[0]["Role"] = subUser.Role;
                    ds.Tables[0].Rows[0]["Email"] = subUser.Email;
                    ds.Tables[0].Rows[0]["Password"] = subUser.Password;
                    ds.Tables[0].Rows[0]["UserName"] = subUser.UserName;
                    con.Update(ds);
                    return true;
                }
            }
            return false;
        }
        private bool doesUserNameAlredyInUse(int SubId, string Username)
        {
            var con = new Connection(constr);
            var ds = con.GetDataSet("p", "Select ID from SubUsers where UserName = '" + Username + "';");
            var usdb = new UserDBServ();
            try
            {
                return int.Parse(ds.Tables[0].Rows[0]["ID"].ToString()) != SubId;
            }
            catch { return false; }
        }
        [WebMethod]
        ///<summary>
        ///takes a admin User object, and a User id. The method deletes the coresponding user from db. Returns wether the delete operation secusseded.
        ///מאפשר למשתמש מנהל לתת את פרטיו כמנהל ואת המספר המזהה של משתמש מסויים ולהסיר את משתמש זה ממסד הנתונים
        /// </summary>
        public bool DeleteSubUser(User UpUser, int id)
        {
            if (doesSubBelongToThisUser(id, UpUser))
            {
                try
                {
                    Connection con = new Connection(constr);
                    con.openCon();
                    bool a = con.ExequteNoneQury("Delete from SubUsers where ID =" + id + ";");
                    return a;
                }
                catch
                {
                    return false;
                }
            }
            else { return false; }
        }

        private bool doesSubBelongToThisUser(int id, User user)
        {
            var con = new Connection(constr);
            string q = "Select * from SubUsers where ID = " + id + ";";
            var ds = con.GetDataSet("p", q);
            var usdb = new UserDBServ();
            return int.Parse(ds.Tables[0].Rows[0]["BelongsToUpperUser"].ToString()) == user.ID;
        }
        [WebMethod]
        ///<summary>
        ///takes  a  user with username and password, and returns the full user
        ///לוקח עצם של משתמש עם שם משתמש וססמה ומחסיר משתמש מלא
        /// </summary>
        public SubUser GetFullUser(SubUser user)
        {
            if (DoesSubExists(user.UserName, user.Password))
            {
                var con = new Connection(constr);
                var ds = con.GetDataSet("0", "Select top 1 * from SubUsers where UserName = '" + user.UserName + "' AND Password = '" + user.Password + "' ;");
                var fullUser = new SubUser();
                fullUser.Id = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                fullUser.BelongsToUpperUser = int.Parse(ds.Tables[0].Rows[0]["BelongsToUpperUser"].ToString());
                fullUser.FName = ds.Tables[0].Rows[0]["FName"].ToString();
                fullUser.LName = ds.Tables[0].Rows[0]["LName"].ToString();
                fullUser.Role = ds.Tables[0].Rows[0]["Role"].ToString();
                fullUser.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                fullUser.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                fullUser.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                return fullUser;
            }
            else
            {
                return null;
            }
        }

        //אומר האם המשתמש התחתון קיים במערכת
        private bool DoesSubExists(string userName, string password)
        {
            var con = new Connection(constr);
            var ds = con.GetDataSet("0", "Select top 1 * from SubUsers where UserName = '" + userName + "' AND Password = '" + password + "' ;");
            try
            {
                return ds.Tables[0].Rows[0][0] != null;
            }
            catch { return false; }
        }
        [WebMethod]
        ///<summary>
        ///takes a subuser ditailes and returns a limited inventory table
        /// מקבל משתמש תחתון ומחזיר את רשימת המלאי של הפריטים שהוא יכול לשאול
        /// </summary>
        public DataTable getLimitedSubUserInventoryList(SubUser subUser)
        {
            if (DoesSubExists(subUser.UserName, subUser.Password))
            {
                var con = new Connection(constr);
                var ds = con.GetDataSet("items", "select ID, Name from Inventory where OwnerUserId =" + subUser.BelongsToUpperUser.ToString() + ";");
                return ds.Tables[0];
            }
            return null;
        }
        [WebMethod]
        ///<summary>
        ///takes an order and adds it to the db, extra verubles for sequrity
        /// מקבל הזמנה ומוסיף אותה לטבלה המשתנים הנוספים לאבטחה
        /// </summary>
        /// <returns>
        /// מחזיר את האיי די של ההזמנה החדשה
        /// </returns>
        public int addOrder(Order order, SubUser subUser)
        {
            if (DoesSubExists(subUser.UserName, subUser.Password))
            {
                if (doesSubBelongToThisUser(subUser.Id, new WebServ1.User() { ID = subUser.BelongsToUpperUser }))
                {
                    var con = new Connection(constr);
                    var emptyDs = con.GetDataSet("1", "Select * from Orders where 1<0");
                    var newDr = emptyDs.Tables[0].NewRow();
                    newDr["BySubUser"] = subUser.Id;
                    newDr["ItemId"] = order.ItemId;
                    newDr["Amount"] = order.Amount;
                    newDr["ToUpperUser"] = order.ToUpperUser;
                    newDr["Aproved"] = "FALSE";
                    newDr["Rejected"] = "FALSE";
                    newDr["IsActive"] = "TRUE";

                    newDr["OrderDate"] = DateTime.Now.ToString();

                    newDr["ItemName"] = order.ItemName;
                    con.InsertDataRow(newDr);
                    try
                    {
                        var updated = con.GetDataSet("1", "Select top 1 ID from Orders where BySubUser = " + subUser.Id + " AND ItemId = " + order.ItemId + " AND Amount = " + order.Amount + " AND ToUpperUser = " + order.ToUpperUser + " ORDER BY ID DESC;");
                        return int.Parse(updated.Tables[0].Rows[0][0].ToString());
                    }
                    catch
                    {
                        return -1;
                    }

                }
                else
                {
                    //throw new UnauthorizedAccessException();
                    return -1;
                }
            }
            else
            {
                //throw new UnauthorizedAccessException();
                return -2;
            }
        }

        [WebMethod]
        ///<summary>
        ///get all users orders
        /// מוציא טבלה עם כל ההזמנות של המשתמש
        /// </summary>
        /// <returns>
        ///returns a datatable with all the user's orders.
        /// </returns>
        public DataTable getOrders(SubUser user)
        {
            if (DoesSubExists(user.UserName, user.Password))
            {
                var sequrUser = GetFullUser(user);
                var con = new Connection(constr);
                DataSet ds = con.GetDataSet("orders", "Select * From Orders where BySubUser = " + sequrUser.Id + " ;");
                return ds.Tables[0];
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
        [WebMethod]
        ///<summary>
        ///deletes the order
        /// מוחק הזמנה עם תז שניתם
        /// </summary>
        /// <returns>
        ///void
        /// </returns>
        public void DeleteOrder(User user, int OrdId)
        {
            var con = new Connection(constr);
            var UserServ = new UserDBServ();
            if (UserServ.IsUserPermitted(user))
            {
                var ds = con.GetDataSet("0", $"Select top 1 * from Orders where ID = {OrdId};");
                var SubUserID = int.Parse( ds.Tables[0].Rows[0]["BySubUser"].ToString());
                if (doesSubBelongToThisUser(SubUserID, user))
                {
                    con.openCon();
                    con.ExequteNoneQury($"Delete From Orders Where ID = {OrdId};");
                }
                else
                {
                    throw new UnauthorizedAccessException();
                }
            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }
        [WebMethod]
        ///<summary>
        ///gives the upper user all the details of one of his subUsers based on his id
        /// נותן למשתמש את כל הפרטים של המשמש שאת מספר הזיהוי שלו הוא נותן
        /// </summary>
        /// <returns>
        ///returns the full SubUser.
        /// </returns>
        public SubUser GetYourSubUser(User user, int SubUserID)
        {
            var UserServ = new UserDBServ();
            if (UserServ.IsUserPermitted(user))
            {
                if (doesSubBelongToThisUser(SubUserID, user))
                {
                    var con = new Connection(constr);
                    var ds = con.GetDataSet("0", "Select top 1 * from SubUsers where ID = " + SubUserID + ";");
                    var fullUser = new SubUser();
                    fullUser.Id = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                    fullUser.BelongsToUpperUser = int.Parse(ds.Tables[0].Rows[0]["BelongsToUpperUser"].ToString());
                    fullUser.FName = ds.Tables[0].Rows[0]["FName"].ToString();
                    fullUser.LName = ds.Tables[0].Rows[0]["LName"].ToString();
                    fullUser.Role = ds.Tables[0].Rows[0]["Role"].ToString();
                    fullUser.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                    fullUser.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                    fullUser.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                    return fullUser;
                }
            }
            return null;
        }
        [WebMethod]
        ///<summary>
        ///takes an order and updates it
        /// מעדכן הזמנה
        /// </summary>
        /// <returns>
        ///returns whether the update procces was complited sucssesfuly
        /// </returns>
        public bool UpdateOrderByUpperUser(User user, Order order)
        {
            var UserServ = new UserDBServ();
            if (UserServ.IsUserPermitted(user))
            {
                if (doesOrderBelongToThisUpperUser(order, user))
                {
                    try
                    {
                        var sequreUser = UserServ.GetFullUser(user);
                        var con = new Connection(constr);
                        var ds = con.GetDataSet("0", "Select * from Orders where ID = " + order.ID);
                        ds.Tables[0].Rows[0]["Amount"] = order.Amount;
                        ds.Tables[0].Rows[0]["Aproved"] = order.Aproved.ToString().ToUpper();
                        ds.Tables[0].Rows[0]["Rejected"] = order.Rejected.ToString().ToUpper();
                        ds.Tables[0].Rows[0]["IsActive"] = order.IsActive.ToString().ToUpper();
                        con.Update(ds);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return false;

        }

        //בודק האם שורת הזמנה שייכת למשתמש עליון מסויים
        private bool doesOrderBelongToThisUpperUser(Order order, User user)
        {
            var con = new Connection(constr);
            var UserServ = new UserDBServ();
            var sequreUser = UserServ.GetFullUser(user);
            DataSet ds = con.GetDataSet("0", "Select * From Orders where ID = " + order.ID + ";");
            try { 
                bool result = int.Parse(ds.Tables[0].Rows[0]["ToUpperUser"].ToString()) == sequreUser.ID;
                return result;
            }
            catch
            {
                return false;
            }
        }
    }
}

