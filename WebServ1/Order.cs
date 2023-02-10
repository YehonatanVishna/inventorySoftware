using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServ1
{
    public class Order
    {
        private int iD;
        private int bySubUser;
        private int itemId;
        private float amount;
        private int toUpperUser;
        private bool aproved;
        private bool rejected;
        private string remarkes= "";
        private string itemName;
        private DateTime orderDate;
        private bool isActive;
        public Order()
        {

        }

        public int ID { get => iD; set => iD = value; }
        public int BySubUser { get => bySubUser; set => bySubUser = value; }
        public int ItemId { get => itemId; set => itemId = value; }
        public float Amount { get => amount; set => amount = value; }
        public int ToUpperUser { get => toUpperUser; set => toUpperUser = value; }
        public bool Aproved { get => aproved; set => aproved = value; }
        public bool Rejected { get => rejected; set => rejected = value; }
        public string Remarkes { get => remarkes; set => remarkes = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public DateTime OrderDate { get => orderDate;
            set
            {
                orderDate = value;
            }
            }
        private string status;
        //public string Status
        //{
        //    get
        //    {
        //        if(aproved == false && rejected == false)
        //        {
        //            return "awaiting response";
        //        }
        //        else
        //        {
        //            if(aproved==false && rejected == true)
        //            {
        //                return "rejected";
        //            }
        //            else
        //            {
        //                if(aproved==true && rejected == false)
        //                {
        //                    return "aproved";
        //                }
        //                else
        //                {
        //                    return "error";
        //                }
        //            }
        //        }
        //    }
        //}
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public bool IsActive { get => isActive; set => isActive = value; }
    }
}