using static System.Console;

namespace StaticDateAndMembers
{
    static class TimeUtilClass
    {
        public static void PrintTime() => WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate() => WriteLine(DateTime.Now.ToShortDateString());
    }
}
