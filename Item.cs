using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoApp
{
    public abstract class Item
    {
        public string ItemId { get; set; }
        public int ItemType { get; set; }
        public string ItemTitle { get; set; }
        public int NumberOfCopies { get; set; }
        public string Location { get; set; }

        //Age below which may not borrow
        public int AgeRestriction { get; set; }
        public int ItemCondition { get; set; }
    }

    public class CheckedInLocation
    {
        public string BranchName { get; set; }
        public string Aisle { get; set; }
        public string Shelf { get; set; }
    }

    public enum ItemCondition
    {
        Good,
        Fair,
        Poor,
        Damaged,
        Unusable
    }

    public class ItemType
    {
        public string ItemTypeName { get; set; }

        public ItemType(string itemTypeName)
        {
            ItemTypeName = itemTypeName;
        }

        public ItemType()
        {
            ItemTypeName = string.Empty;
        }
    }
}
