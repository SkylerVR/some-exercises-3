
using System.Globalization;
using System.Text;

static void CurrentDate()
{
    DateTime currentTime = DateTime.Now;
    string formattedDateTime = currentTime.ToString("yyyy-MM-dd HH:mm");

    Console.WriteLine(formattedDateTime);
}

CurrentDate();

static void CurrentLondonDate()
{
    DateTime currentTime = DateTime.UtcNow;
    string formattedDateTime = currentTime.ToString("yyyy-MM-dd HH:mm");

    Console.WriteLine(formattedDateTime);
}

CurrentLondonDate();

static int DaysBetween(DateTime startDate, DateTime endDate)
{
    TimeSpan duration = endDate.Date - startDate.Date;
    int days = duration.Days;
    return days;
}

Console.WriteLine(DaysBetween(new DateTime(2022, 1, 1), new DateTime(2023, 1, 31)));

bool IsLeapYear(int year)
{

    bool isLeap = DateTime.IsLeapYear(year);
    return isLeap;

}
Console.WriteLine(IsLeapYear(2022));

static void FirstDayOfPreviousMonth()
{
    var currentDate = DateTime.Now;
    var previousMonthFirstDay = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(-1);
    Console.WriteLine(previousMonthFirstDay);
}

FirstDayOfPreviousMonth();

static void LastDayOfPreviousMonth()
{
    var currentDate = DateTime.Now;
    var firstDayOfCurrentMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
    var lastDayOfPreviousMonth = firstDayOfCurrentMonth.AddDays(-1);
    Console.WriteLine(lastDayOfPreviousMonth);
}

LastDayOfPreviousMonth();

//static void CurrentWeekDay()
//{
//    var currentDate = DateTime.Now;
//    var geoCulture = CultureInfo.CreateSpecificCulture("ka-GE");
//    var currentDayOfWeek = geoCulture.DateTimeFormat.GetDayName(currentDate.DayOfWeek);
//    Console.OutputEncoding = Encoding.UTF8;
//    Console.WriteLine(currentDayOfWeek);
//}

//CurrentWeekDay();


static void CurrentWeekDay()
{
    DateTime currentDate = DateTime.Now;
    CultureInfo geoCulture = new CultureInfo("ka-GE");
    string currentDayOfWeek = geoCulture.DateTimeFormat.GetDayName(currentDate.DayOfWeek);
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine(currentDayOfWeek);

}

CurrentWeekDay();
