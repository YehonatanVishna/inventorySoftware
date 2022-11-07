using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WpfApp1;
using System.Data;
using System.Data.SqlClient;
//made by yehonatan vishna

namespace WebServ1
{
    /// <summary>
    /// Summary description for UserDBServ
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserDBServ : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello Worldrerer";
        }
        [WebMethod]
        public Boolean reg(User usr)
        {
                Connection con = new Connection("Server = 'DESKTOP-2BGT9RO\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True;");
                con.openCon();
                string b = "Insert into [StorageSystem].[dbo].[Users] (FName, LName, BDate, compeny, email, password) Values (N'" + usr.Fname + "', N'" + usr.Lname + "' , " + "CAST(N'" + usr.BDate.ToShortDateString() + "' AS DateTime)" + " , N'" + usr.Compeny + "', N'" + usr.Email + "' , N'" + usr.Password + "');";
                bool a = con.ExequteNoneQury(b);
                con.CloseCon();
                return a;

        }
        [WebMethod]
        public bool IsUserPermitted(User usr)
        {
            Connection con = new Connection("Server = 'DESKTOP-2BGT9RO\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True;");
            DataSet ds = con.GetDataSet("logged", "select * from users where email = N'" + usr.Email + "' AND password= N'" + usr.Password + "';");
            return ds.Tables[0].Rows[0]["ID"] != null;

            try
            {
            }
            catch {
                return false;
            }
        }
        //made by yehonatan vishna
        [WebMethod]
        public User GetFullUser(User usr)
        {
            User user = new User();
            if (IsUserPermitted(usr))
            {
                Connection con = new Connection("Server = 'DESKTOP-2BGT9RO\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True;");
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
        public bool updateUser(User OldUsr, User NewUsr)
        {
            if (IsUserPermitted(OldUsr))
            {
                Connection con = new Connection("Server = 'DESKTOP-2BGT9RO\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True;");
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
        public bool DeleteUser(User usr) {
            Connection con = new Connection("Server = 'DESKTOP-2BGT9RO\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True;");
            con.openCon();
            return con.ExequteNoneQury("Delete From users where email='" + usr.Email + "' AND password = '" + usr.Password + "'");

        }
        [WebMethod]
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
        public DataTable GetAdminUserTbl(User user)
        {
            if (IsAdmin(user))
            {
                Connection con = new Connection("Server = 'DESKTOP-2BGT9RO\\SQLEXPRESS'; Database = StorageSystem; Trusted_Connection = True; ");
                con.openCon();
                DataSet ds = con.GetDataSet("Users", "Select * From Users");
                DataTable dt = ds.Tables[0];
                return dt;
            }
            else { return null; }
        }
    }
}
