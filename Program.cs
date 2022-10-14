
using Squirrel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var mgr = new UpdateManager("http://wwwclawv.beget.tech/dst2"))
                {
                    mgr.UpdateApp();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


            Worker w = new Worker();
            w.Start();
        }
    }
}
