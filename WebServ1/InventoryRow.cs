using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//made by yehonatan vishna

namespace WebServ1
{
    public class InventoryRow
    {
        private int id;
        private string name;
        private int quantity;
        private int neededQuantity;
        public InventoryRow() { }
        public InventoryRow(int id, string name, int q, int nq) {
            this.id = id;
            this.name = name;
            this.quantity = q;
            this.neededQuantity = nq;
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public int NeededQuantity
        {
            get { return this.neededQuantity; }
            set { this.neededQuantity = value; }
        }
    }
}
//made by yehonatan vishna
