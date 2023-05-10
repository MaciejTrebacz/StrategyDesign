using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var strategy = new CarStrategy();
            var map = new Map(strategy);
            map.CreateRoute(new Coordinate(){Lat = 20.3321,Long = .3131}  , new Coordinate(){Lat = 23131, Long = 4444141}  );
            Console.ReadLine();
        }
    }
}
