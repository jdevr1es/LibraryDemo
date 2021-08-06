using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoApp
{
    public class CheckOut
    {
        public string ItemBorrowedId { get; set; }
        public string BorrowId { get; set; }
        public DateTime CheckoutDateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckinDateTime { get; set; }
        public ItemCondition CheckinCondition { get; set; }
        public string Comments { get; set; }
    }
}
