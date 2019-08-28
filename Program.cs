using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace virtual_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input the total memory");
            var input = Console.ReadLine();
            var foregroundApps = new List<Dictionary<int, int>>();
            var backgroundApps = new List<Dictionary<int, int>>();
            var outputApps = new List<Dictionary<int, int>>();

            // foreground apps
            foregroundApps.Add(new Dictionary<int, int>{
                {1,10},
                {2,15},
                {3,17}
            });

            // background apps
            backgroundApps.Add(new Dictionary<int, int>{
                {1,3},
                {2,2},
            });

            for(int i = 0; i < foregroundApps.Count; i++) {
                for(int x = 0; x < backgroundApps.Count; x++) {
                    var foregound = foregroundApps[i];
                    var background = backgroundApps[x];

            
                }
            }
        }
    }
}
