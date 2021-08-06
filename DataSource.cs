using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoApp
{
    public static class DataSource
    {

        // Collections holding the data used by the prototype application
        public static List<LibraryUser> Users;
        public static List<CheckOut> CheckOuts;
        public static List<Branch> Branches;
        public static List<Book> Books;

        public static List<ItemType> ItemTypes;

        public static void CreateData()
        {
            ItemTypes = new List<ItemType>()
                {
                    new ItemType(){ItemTypeName="harcover book"},
                    new ItemType(){ItemTypeName="softcover book"},
                    new ItemType(){ItemTypeName="ebook"},
                    new ItemType(){ItemTypeName="CD"},
                    new ItemType(){ItemTypeName="DVD"},
                    new ItemType(){ItemTypeName="newspaper"}
                };
            
            Users = new List<LibraryUser>()
            {
                new LibraryUser() { UserName = "Vallee", UserId = "A123", UserDob = DateTime.Today},
                new LibraryUser() { UserName = "Smith", UserId = "A124", UserDob = DateTime.Today},
                new LibraryUser() { UserName = "Jones", UserId = "A125", UserDob = DateTime.Today}
            };

            Books = new List<Book>()
            {
                new Book() { IsbnNumber = "1234", ItemId = "A123", ItemTitle ="Oh, The Places You'll Go!",ItemType = 0, NumberOfCopies = 1, Location = "Main", AgeRestriction = 13, ItemCondition=0 },
                new Book() { IsbnNumber = "1235", ItemId = "A1253", ItemType = 0, ItemTitle="Gone WithThe Wind",NumberOfCopies = 1, Location = "Main", AgeRestriction = 13, ItemCondition=0 },

            };

            Branches = new List<Branch>()
            {
                new Branch() { BranchName = "Main", BranchAddress = "123 Main St." },
            };
        }
    }
}
