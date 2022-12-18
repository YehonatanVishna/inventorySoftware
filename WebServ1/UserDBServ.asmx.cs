using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WpfApp1;
using System.Data;
using System.Data.SqlClient;
using System.Net;
//made by yehonatan vishna

namespace WebServ1
{
    /// <summary>
    /// some functions to interact with users and their details in db
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserDBServ : System.Web.Services.WebService
    {
        public String constr = "Server = '" + Dns.GetHostName() + "\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ";

        [WebMethod]
        ///<summary>
        ///a function that takes user object and adds it to users table in the db.
        /// </summary>
        public Boolean reg(User usr)
        {
                Connection con = new Connection(constr);
                con.openCon();
                string b = "Insert into [StorageSystem].[dbo].[Users] (FName, LName, BDate, compeny, email, password) Values (N'" + usr.Fname + "', N'" + usr.Lname + "' , " + "CAST(N'" + (usr.BDate.GetValueOrDefault()).ToShortDateString() + "' AS DateTime)" + " , N'" + usr.Compeny + "', N'" + usr.Email + "' , N'" + usr.Password + "');";
                bool a = con.ExequteNoneQury(b);
                con.CloseCon();
                return a;

        }
        [WebMethod]
        ///<summary>
        ///a function that returns whether a user exists in users table in db
        /// </summary>
        public bool IsUserPermitted(User usr)
        {
            try
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("logged", "select * from users where email = N'" + usr.Email + "' AND password= N'" + usr.Password + "';");
                return ds.Tables[0].Rows[0]["ID"] != null;
            }
            catch {
                return false;
            }
        }
        [WebMethod]
        ///<summary>
        ///adds a new user to users table in db and returns his id.
        /// </summary>
        public int AddEmptyUser()
        {
            Connection con = new Connection(constr);
            con.openCon();
            string b = "Insert into [StorageSystem].[dbo].[Users] (FName, LName, BDate, compeny, email, password) Values (N'new user', N'' ,'' , N'', N'' , N'');";
            bool a = con.ExequteNoneQury(b);
            DataSet ds = con.GetDataSet("newUser", "Select * from Users where FName = 'new user'");
            int newId = int.Parse(ds.Tables[0].Rows[ds.Tables[0].Rows.Count-1][0].ToString());
            con.CloseCon();
            return newId;

        }
        //made by yehonatan vishna
        [WebMethod]
        ///<summary>
        ///takes a basic user with only email and passwor. returns a full user with all the user details as they are in the db.
        /// </summary>
        public User GetFullUser(User usr)
        {
            User user = new User();
            if (IsUserPermitted(usr))
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("logged", "select * from users where email = '" + usr.Email + "' AND password= '" + usr.Password + "';");
                user.ID = int.Parse(ds.Tables["logged"].Rows[0]["ID"].ToString());
                user.Fname = ds.Tables["logged"].Rows[0]["FName"].ToString();
                user.Lname = ds.Tables["logged"].Rows[0]["LName"].ToString();
                user.BDate = DateTime.Parse(ds.Tables["logged"].Rows[0]["BDate"].ToString());
                user.Compeny = ds.Tables["logged"].Rows[0]["compeny"].ToString();
                user.Email = ds.Tables["logged"].Rows[0]["email"].ToString();
                user.Password = ds.Tables["logged"].Rows[0]["Password"].ToString();
            }
            return user;
        }
        [WebMethod]
        ///<summary>
        ///takes a basic user with only email and passwor. returns a full user with all the user details as they are in the db.
        /// </summary>
        public String[] GetFullUserDits(User usr)
        {
            User user = new User();
            if (IsUserPermitted(usr))
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("logged", "select * from users where email = '" + usr.Email + "' AND password= '" + usr.Password + "';");
                user.ID = int.Parse(ds.Tables["logged"].Rows[0]["ID"].ToString());
                user.Fname = ds.Tables["logged"].Rows[0]["FName"].ToString();
                user.Lname = ds.Tables["logged"].Rows[0]["LName"].ToString();
                user.BDate = DateTime.Parse(ds.Tables["logged"].Rows[0]["BDate"].ToString());
                user.Compeny = ds.Tables["logged"].Rows[0]["compeny"].ToString();
                user.Email = ds.Tables["logged"].Rows[0]["email"].ToString();
                user.Password = ds.Tables["logged"].Rows[0]["Password"].ToString();
            }
            var d = new string[7];
            d[0] = user.Email;
            return d;
        }
        [WebMethod]
        ///<summary>
        ///takes the admin user details (as an object), an object contaning user's motified detailes, and a user id. returns whether the change of user details in db secseded.
        /// </summary>
        public bool updateUserByIdAdmin( int id, User Admin, User NewUsr)
        {
            if (IsAdmin(Admin))
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("logged", "select * from users where ID=" + id.ToString() + ";");
                ds.Tables["logged"].Rows[0]["FName"] = NewUsr.Fname;
                ds.Tables["logged"].Rows[0]["LName"] = NewUsr.Lname;
                ds.Tables["logged"].Rows[0]["BDate"] = NewUsr.BDate;
                ds.Tables["logged"].Rows[0]["compeny"] = NewUsr.Compeny;
                ds.Tables["logged"].Rows[0]["email"] = NewUsr.Email;
                ds.Tables["logged"].Rows[0]["password"] = NewUsr.Password;
                con.Update(ds);
                return true;
            }
            return false;
        }
        [WebMethod]
        ///<summary>
        ///takes the user details (as an object), and an object contaning user's motified detailes. returns whether the change of user details in db secseded.
        /// </summary>
        public bool updateUser(User OldUsr, User NewUsr)
        {
            if (IsUserPermitted(OldUsr))
            {
                Connection con = new Connection(constr);
                DataSet ds = con.GetDataSet("logged", "select * from users where email = '" + OldUsr.Email + "' AND password= '" + OldUsr.Password + "';");
                ds.Tables["logged"].Rows[0]["FName"] = NewUsr.Fname;
                ds.Tables["logged"].Rows[0]["LName"] = NewUsr.Lname;
                ds.Tables["logged"].Rows[0]["BDate"] = NewUsr.BDate;
                ds.Tables["logged"].Rows[0]["compeny"] = NewUsr.Compeny;
                ds.Tables["logged"].Rows[0]["email"] = NewUsr.Email;
                ds.Tables["logged"].Rows[0]["password"] = NewUsr.Password;
                con.Update(ds);
                return true;
            }
            return false;
        }
        //made by yehonatan vishna

        [WebMethod]
        ///<summary>
        ///takes a user object, and deletes the coresponding user from db. Returns wether the delete operation secusseded.
        /// </summary>
        public bool DeleteUser(User usr) {
            Connection con = new Connection(constr);
            con.openCon();
            return con.ExequteNoneQury("Delete From users where email='" + usr.Email + "' AND password = '" + usr.Password + "'");
        }
        [WebMethod]
        ///<summary>
        ///takes a admin User object, and a User id. The method deletes the coresponding user from db. Returns wether the delete operation secusseded.
        /// </summary>
        public bool DeleteUserAdmin(User Admin ,int id)
        {
            User user = Admin;
            if (IsAdmin(user))
            {
                try
                {
                    Connection con = new Connection(constr);
                    con.openCon();
                    bool a = con.ExequteNoneQury("Delete from Users where ID =" + id + ";");
                    return a;
                }
                catch
                {
                    return false;
                }
            }
            else { return false; }
        }
        [WebMethod]
        ///<summary>
        ///checks wether a user is a admin.
        /// </summary>
        public bool IsAdmin(User user)
        {
            if (user.Email.Equals("admin@administrator.adm") && user.Password.Equals("Admin"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [WebMethod]
        ///<summary>
        ///takes a User object. Asuming the user is admin, the method would return a DataTable with all the User's data
        /// </summary>
        public DataTable GetAdminUserTbl(User user)
        {
            if (IsAdmin(user))
            {
                Connection con = new Connection(constr);
                con.openCon();
                DataSet ds = con.GetDataSet("Users", "Select * From Users");
                DataTable dt = ds.Tables[0];
                return dt;
            }
            else { return null; }
        }
        /// <summary>
        /// checks whether an email is already regestered with a user.
        /// </summary>
        [WebMethod]
        public bool DoesEmailExist(string email)
        {
            var con = new Connection(constr);
            var ds = con.GetDataSet("users", "Select * from Users where email = '" + email + "';");
            try
            {
                return ds.Tables["users"].Rows[0]["ID"] != null;
            }
            catch
            {
                return false;
            }
        }

    }
}
