using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Scripts.Async
{
    public class MakeBreafast
    {
        public void MakeCoffee()
        {
            Console.WriteLine("开始冲咖啡");
            System.Threading.Thread.Sleep(6000);
        }

        public void MakePorrige()
        {
            Console.WriteLine("开始煮粥");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
