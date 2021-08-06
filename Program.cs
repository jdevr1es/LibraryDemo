using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoApp
{
    public class Program
    {


        private static string itemId;

        public static void Main(string[] args)
        {
            DataSource.CreateData();

            List<CheckOut> checkedOut = CheckOut();

            //Display items checked out
            foreach (CheckOut c in checkedOut)
            {
                Console.WriteLine(c.BorrowerId);
                Console.WriteLine(c.ItemBorrowedId);
                Console.WriteLine(c.CheckoutDateTime);
                Console.WriteLine(c.DueDate);
                Console.WriteLine();
            }
        }

        public static List<CheckOut> CheckOut()
        {
            //Dummy for scanning borrower card
            Console.WriteLine("Enter Borrower ID: ");
            string borrowerID = Console.ReadLine();

            var checkedOut = new List<CheckOut>();
            string itemId;
            do
            {
                //Dummy for scanning item
                Console.WriteLine("Enter Item ID: ");
                itemId = Console.ReadLine();
                if (itemId != String.Empty)
                {
                    var checkedOutDateTime = DateTime.Now;
                    var dueDate = checkedOutDateTime.AddDays(14);
                    CheckOut CO = new CheckOut(itemId, borrowerID, checkedOutDateTime, dueDate);
                    checkedOut.Add(CO);
                }
            }
            while (itemId != String.Empty);
            return checkedOut;
        }

    }
}
