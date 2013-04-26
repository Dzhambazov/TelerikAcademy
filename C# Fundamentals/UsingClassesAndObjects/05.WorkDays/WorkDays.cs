using System;
class WorkDays
{
   static DateTime[] holidays =
    {
        new DateTime(2013,01,25),
        new DateTime(2013,03,03),
        new DateTime(2013,05,06),
        new DateTime(2013,06,02),
        new DateTime(2013,09,06),
        new DateTime(2013,11,01),
        new DateTime(2013,12,24),
        new DateTime(2013,12,24)
    };

    static int WorkDayss(DateTime dateInFuture)
    {
        DateTime day = DateTime.Today;
        int daysCount = (int)(dateInFuture.Date - DateTime.Today.Date).TotalDays;
        int workDays = daysCount;
        for (int i = 0; i < daysCount; i++)
        {
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                workDays--;
            }
            foreach (DateTime h in holidays)
            {
                if (day.Date == h.Date && (day.DayOfWeek != DayOfWeek.Saturday || day.DayOfWeek != DayOfWeek.Sunday))
                {
                    workDays--;
                }
            }
            day = day.AddDays(1);
        }
        return workDays;
    }

    static void Main()
    {
        DateTime dateInFuture = new DateTime(2015,03,10);
        Console.WriteLine("{0} working days from today to {1}",WorkDayss(dateInFuture),dateInFuture.Date);

    }
}
