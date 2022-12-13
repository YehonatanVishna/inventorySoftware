using System;
using System.Collections.Generic;
using System.Linq;

namespace storageUniversal
{
    public class InventoryRow
    {
        //defines some properies
        private int id;
        private string name;
        private float quantity;
        private float neededQuantity;
        private int ownerUserId;
        private float amountOut;
        private string remarks;
        public InventoryRow() { }
        public InventoryRow(int id, string name, int q, int nq, int oui)
        {
            this.id = id;
            this.name = name;
            this.quantity = q;
            this.neededQuantity = nq;
            this.ownerUserId = oui;
        }
        //getters and setters for all the properties listed above
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public float Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public float NeededQuantity
        {
            get { return this.neededQuantity; }
            set { this.neededQuantity = value; }
        }
        public int OwnerUserId
        {
            get { return this.ownerUserId; }
            set { this.ownerUserId = value; }
        }
        public float AmountOut
        {
            get { return this.amountOut; }
            set { this.amountOut = value; }
        }
        public String Remarkes
        {
            get { return this.remarks; }
            set { this.remarks = value; }
        }
        // a fution that creatates another InventoryRow obj identical to this one
        public InventoryRow copy()
        {
            InventoryRow a = new InventoryRow();
            a.ID = this.id;
            a.Quantity = this.quantity;
            a.OwnerUserId = this.ownerUserId;
            a.NeededQuantity = this.neededQuantity;
            a.Name = this.name;
            a.Remarkes = this.remarks;
            return a;
        }
        // a function that returns wether another InventoryRow object is identical to this one
        public bool Equal(InventoryRow row)
        {
            bool IdSame = this.id == row.ID;
            bool QSame = this.quantity == row.Quantity;
            bool OUIdSame = this.ownerUserId == row.OwnerUserId;
            bool NQSame = this.neededQuantity == row.NeededQuantity;
            bool NameSame;
            if ((row.Name == null && this.name != null) || (row.Name != null && this.name == null))
            {
                NameSame = false;
            }
            else
            {
                if ((row.Name == null && this.name == null))
                {
                    NameSame = true;
                }
                else
                {
                    NameSame = this.name.Equals(row.Name.ToString());
                }
            }
            bool RSame;
            if ((row.Remarkes == null && this.remarks != null) || (row.Remarkes != null && this.remarks == null))
            {
                RSame = false;
            }
            else
            {
                if ((row.Remarkes == null && this.remarks == null))
                {
                    RSame = true;
                }
                else
                {
                    RSame = this.remarks.Equals(row.Remarkes.ToString());
                }
            }
            return IdSame && QSame && OUIdSame && NQSame && NameSame && RSame;
        }
    }
}