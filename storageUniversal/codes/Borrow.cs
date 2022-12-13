using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storageUniversal.BorowwDb;

namespace storageUniversal.codes
{
    public class Borrow
    {
        // Fields
        private int itemId;
        private string borrowedBy;
        private DateTime when;
        private float quantity;
        private float borrowingId;
        private int userId;
        private string name;

        // Default constructor
        public Borrow() { }

        // Constructor with item ID parameter
        private Borrow(int id)
        {
            // Set the item ID
            this.ItemId = id;
        }

        // Property for the item ID
        public int ItemId
        {
            get { return itemId; }
            set { this.itemId = value; }
        }

        // Property for the borrower's name
        public string BorrowedBy
        {
            get => borrowedBy;
            set => borrowedBy = value;
        }

        // Property for the date and time the item was borrowed
        public DateTime When
        {
            get => when;
            set => when = value;
        }

        // Property for the quantity of the item borrowed
        public float Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        // Property for the ID of the borrowing
        public float BorrowingId
        {
            get => borrowingId;
            set => borrowingId = value;
        }

        // Property for the ID of the user
        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        // Property for the name of the user
        public string Name
        {
            get => name;
            set => name = value;
        }

        // Method to set the name of the user based on their ID
        public async Task<string> SetName(int id)
        {
            // Create a new instance of the BorowwDb.BorowwingsDBSoapClient class
            var b = new BorowwDb.BorowwingsDBSoapClient();

            // Set the name based on the ID using the web service
            name = await b.getNameAsync(id);

            // Return the name
            return name;
        }
    }

}
