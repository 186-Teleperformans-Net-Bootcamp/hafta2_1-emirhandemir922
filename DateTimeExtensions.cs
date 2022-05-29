namespace Teleperformance._2s
{
    public static class DateTimeExtensions
    {
        public static void Ago(this DateTime date) 
        {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now.Subtract(date);

            Console.WriteLine(@"{0} Days, {1} Hours, {2} Minutes ago", timeSpan.Day, timeSpan.Hours, timeSpan.Minutes);
        }
    }
}
