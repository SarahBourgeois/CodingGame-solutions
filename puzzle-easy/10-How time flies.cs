using System;
using System.Globalization;

class Solution
{
    static void Main(string[] args)
    {
        string BEGIN = Console.ReadLine();
        string END = Console.ReadLine();

        var beginDate = DateTime.ParseExact(BEGIN, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(END, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        TimeSpan ts = endDate - beginDate;

        var daysDifference = ts.TotalDays;
        var monthsDifference = (DateTime.MinValue + (endDate - beginDate)).Month - 1;
        var yearsDifference = endDate.Subtract(beginDate).Days / 365;

        if (yearsDifference > 0)
            Console.Write("{0} year{1}, ", yearsDifference, yearsDifference > 1 ? "s" : "");

        if (monthsDifference > 0)
            Console.Write("{0} month{1}, ", monthsDifference, monthsDifference > 1 ? "s" : "");

          Console.WriteLine("total {0} days", daysDifference);
    }
}