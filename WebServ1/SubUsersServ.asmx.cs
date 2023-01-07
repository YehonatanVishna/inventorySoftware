﻿using System;
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
                String nqury = "Insert into SubUsers (BelongsToUpperUser, FName, LName, Role, Email, Password) Values (" + subUser.BelongsToUpperUser + ", '" + subUser.FName + "', '" + subUser.LName + "', '" + subUser.Role + "', '" + subUser.Email + "', '" + subUser.Password + "' );";
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
                    ds.Tables[0].Rows[0]["BelongsToUpperUser"] = subUser.BelongsToUpperUser;
                    ds.Tables[0].Rows[0]["FName"] = subUser.FName;
                    ds.Tables[0].Rows[0]["LName"] = subUser.LName;
                    ds.Tables[0].Rows[0]["Role"] = subUser.Role;
                    ds.Tables[0].Rows[0]["Email"] = subUser.Email;
                    ds.Tables[0].Rows[0]["Password"] = subUser.Password;
                    con.Update(ds);
                    return true;
                }
            }
            return false;
        }
    }
}
