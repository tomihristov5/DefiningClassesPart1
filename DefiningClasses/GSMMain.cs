namespace DefiningClasses
{
    using System;

    public class GSMMain
    {

        static void Main()
        {
            GSMTest.PrintGSMsInfo(GSMTest.GenerateGSMs(3));
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.CreateCalltestHistory();
            GSMCallHistoryTest.DisplayCalltestHistory();
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0}\n{1}", "Price after the longest call is removed: ", new string('-', 50));
            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0}\n{1}", "Call history after the longest call is removed: ", new string('-', 50));
            GSMCallHistoryTest.DisplayCalltestHistory();
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.testGSM.ClearCallHistory();
            Console.WriteLine("{0}\n{1}", "Call history list is cleared...", new string('-', 50));
            GSMCallHistoryTest.DisplayCalltestHistory();
        }
    }
}
