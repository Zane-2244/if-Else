using System;


namespace IESC
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autemn;
            switch (season)
            {
                case Season.Autemn:
                case Season.Summer:
                    Console.WriteLine("we've got promotian.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;

            }
        }
    }
}
