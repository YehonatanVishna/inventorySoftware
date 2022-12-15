using System;
namespace WebServ1
{
    public class User
    {
        //defining basic properties
        private int id;
        private string fname;
        private string lname;
        private DateTime bdate;
        private string compeny;
        private string email;
        private string password;
        // empty constractor
        public User()
        {

        }
        // a constaractor that gets all properties at create
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

        //getters + setters for properties
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
        //In order to display BDate in standard CalendarDatePicker I had to write a property that would return BDate as a nullable DateTimeOffset
        public DateTimeOffset? BDateTimeOffset
        {
            get
            {
                try { return DateTimeOffset.Parse(this.BDate.ToString()); }
                catch { return null; }
            }
            set { this.bdate = DateTime.Parse(value.ToString()); }
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
        // a fution that creatates another User obj identical to this one
        public User copy()
        {
            User a = new User();
            a.ID = this.id;
            a.Fname = this.Fname;
            a.Lname = this.Lname;
            a.BDate = this.BDate;
            a.compeny = this.compeny;
            a.email = this.email;
            a.password = this.password;
            return a;
        }
        // a function that returns wether another User object is identical to this one
        public bool IsSame(User user)
        {
            try
            {
                bool idS = this.ID == user.ID;
                bool FnameS = this.Fname.Equals(user.Fname);
                bool LnameS = this.Lname.Equals(user.Lname);
                bool DateS = this.BDate.Equals(user.BDate);
                bool CompS = this.compeny.Equals(user.Compeny);
                bool EmailS = this.email.Equals(user.Email);
                bool PassS = this.password.Equals(user.Password);
                return idS && FnameS && LnameS && DateS && CompS && EmailS && PassS;
            }
            catch
            {
                return false;
            }
        }
        //made by yehonatan vishna

    }
}
