using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListLogic
{
    internal class StringHelper
    {
        public static DateTime ConvertStringToDate(string deadline)
        {
            string[] parsedate = deadline.Split('-');
            int year = int.Parse(parsedate[0]);
            int month = int.Parse(parsedate[1]);
            int day = int.Parse(parsedate[2]);
            DateTime dateTime = new DateTime(year, month, day);
            return dateTime;
        }
    }
}
