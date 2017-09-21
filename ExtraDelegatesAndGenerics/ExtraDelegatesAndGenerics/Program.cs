using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            // init marathon
            Marathon boston17 = new Marathon();
            DopingControl usada = new DopingControl();
            Admin iaaf = new Admin();
            Prices baa = new Prices();

            // [todo]

            string [] runners = { "Kirui", "Rupp", "Osako", "Biwott", "Chebet", "Abdirahman",
                "Maiyo", "Sefir", "Puskedra", "Ward"};
            
            // shuffle runners for random results
            Random rnd = new Random((int) DateTime.Now.Ticks);
            List<string> orderedRunners = new List<string>(runners);
            var shuffledRunners = orderedRunners.OrderBy(item => rnd.Next());
            
            // run!
            foreach (string runner in shuffledRunners)
            {
                Thread.Sleep((int) (rnd.NextDouble() * 1000));
                Console.WriteLine("..[to do, remove this]..");
                
            }
        }

    }
}
