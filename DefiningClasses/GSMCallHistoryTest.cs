namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMCallHistoryTest
    {
        public static GSM testGSM = new GSM("TestGSM", "TestModel");
        public static DateTime testCall1Date = DateTime.Parse("16/03/2011 09:25:10");
        public static DateTime testCall2Date = DateTime.Parse("10/03/2011 19:15:30");
        public static DateTime testCall3Date = DateTime.Parse("11/03/2011 14:07:18");
        public static DateTime testCall4Date = DateTime.Parse("14/03/2011 08:15:55");
        public static DateTime testCall5Date = DateTime.Parse("15/03/2011 12:37:03");

        public static Call[] testCalls = 
        {
            new Call(testCall1Date, 50, "0888000111"),
            new Call(testCall2Date, 100, "0888000222"),
            new Call(testCall3Date, 150, "0888000333"),
            new Call(testCall4Date, 200, "0888000444"),
            new Call(testCall5Date, 300, "0888005555")
        };
        public static void CreateCalltestHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCalls(testCalls[i]);
            }
        }
        public static void DisplayCalltestHistory()
        {
            Console.WriteLine(testGSM.PrintCallHistory());
        }
        public static void CalculateAndPrintTestcallsPrice()
        {
            decimal price = testGSM.CalculateTotalCallsPrice(0.37M);
            Console.WriteLine("Total price of test calls: {0:F2}", price);
        }
        public static void RemoveLongestCall()
        {
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1];
            testGSM.DeleteCalls(longestCall);
        }
    }
}
