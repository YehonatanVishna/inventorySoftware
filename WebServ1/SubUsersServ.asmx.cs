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
        public bool createSubUser(SubUser subUser, User UpperUser)
        {
            var usdb = new UserDBServ();
            if (usdb.IsUserPermitted(UpperUser))
            {
                var con = new Connection(constr);
                con.openCon();
                String nqury = "Insert into SubUsers (BelongsToUpperUser, FName, LName, Role, Email, Password) Values (" + subUser.BelongsToUpperUser + ", '" + subUser.FName + "', '" + subUser.LName + "', '" + subUser.Role + "', '" + subUser.Email + "', '" + subUser.Password + "' );";
                bool isok = con.ExequteNoneQury(nqury);
                con.CloseCon();
                return isok;
            }
            else
            {
                return false;
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
    }
}
