using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // RegularExpressions02Race
            string namePattern = "[A-Za-z]";
            string sumPattern = @"\d";

            Dictionary<string, int> raceList = new Dictionary<string, int>();

            string[] participants = Console.ReadLine().Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in participants)
            {
                raceList.Add(item, 0);
            }

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                var currentName = Regex.Matches(input, namePattern);
                var currentsum = Regex.Matches(input, sumPattern);

                string name = String.Concat(currentName);
                int sum = currentsum.Select(x => int.Parse(x.Value)).Sum();
                if (raceList.Keys.Contains(name))
                {
                    raceList[name] += sum;
                }


                input = Console.ReadLine();
            }
                int n = 0;

            var rewordList = raceList.OrderByDescending(x => x.Value).ToList();

            Console.WriteLine($"1st place: {rewordList[0].Key}");
            Console.WriteLine($"2nd place: {rewordList[1].Key}");
            Console.WriteLine($"3rd place: {rewordList[2].Key}");







            //
        }
    }
}
