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
        //תכונות של טיפוס השאלה
        // Fields
        private int itemId;
        private string borrowedBy;
        private DateTime when;
        private float quantity;
        private float borrowingId;
        private int userId;
        private string name;

        //הבנאי הראשי
        // Default constructor
        public Borrow() { }

        //בנאי שמקבל מספר זהות
        // Constructor with item ID parameter
        private Borrow(int id)
        {
            // Set the item ID
            this.ItemId = id;
        }
        //פעולות גט וסט לכל התכונות
        // getters and setters to all properties
        public int ItemId
        {
            get { return itemId; }
            set { this.itemId = value; }
        }


        public string BorrowedBy
        {
            get => borrowedBy;
            set => borrowedBy = value;
        }


        public DateTime When
        {
            get => when;
            set => when = value;
        }


        public float Quantity
        {
            get => quantity;
            set => quantity = value;
        }


        public float BorrowingId
        {
            get => borrowingId;
            set => borrowingId = value;
        }


        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        //בשל הקשרים בטבלה אין בטבלה של ההשאלות את שם הפריט
        //מטרת פעולה זו היא להשיג משירות הרשת את שם הפריט ולשים אותו בתוך העצם
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
