using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoApp
{
    public class Branch
    {
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }

        //public List<OpenHours> BranchHours { get; set; }
    }

    public class OpenHours
    {
        public DayOfWeek WeekDay { get; set; }
        public DateTime Opening { get; set; }
        public DateTime Closing { get; set; }
    }
}
