using System;
using System.Data;
namespace storageUniversal
{
    public class User
    {
        private int id;
        private string fname;
        private string lname;
        private DateTime bdate;
        private string compeny;
        private string email;
        private string password;
        public User()
        {

        }
        public User(string compeny, string Fname, string Lname, DateTime BDate, string email, string password)
        {
            this.compeny = compeny;
            this.fname = Fname;
            this.lname = Lname;
            this.bdate = BDate;
            this.email = email;
            this.password = password;
        }
        //made by yehonatan vishna
        public User(int Id, string compeny, int tz, string Fname, string Lname, DateTime BDate, string email, string password)
        {
            this.id = Id;
            this.compeny = compeny;
            this.fname = Fname;
            this.lname = Lname;
            this.bdate = BDate;
            this.email = email;
            this.password = password;
        }


        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Fname
        {
            get { return this.fname; }
            set { this.fname = value; }
        }
        public string Lname
        {
            get { return this.lname; }
            set { this.lname = value; }
        }
        public DateTime BDate
        {
            get { return this.bdate; }
            set { this.bdate = value; }
        }
        public string Compeny
        {
            get { return this.compeny; }
            set { this.compeny = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public string insertQury(string tableN)
        {
            return "Insert INTO " + tableN + " (Fname, LName, BDate, City, email, password) VALUES " + "(" + ",'" + this.fname + "','" + this.lname + "','" + this.bdate.ToString() + "','" + this.email + "','" + this.password + "');";
        }
        //made by yehonatan vishna

    }
}
