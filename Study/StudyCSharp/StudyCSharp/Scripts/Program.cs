using StudyCSharp.Scripts.Async;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTAP eapAsync = new AsyncTAP();
            eapAsync.MakeBreafast();
            Console.ReadLine();
        }
    }
}
