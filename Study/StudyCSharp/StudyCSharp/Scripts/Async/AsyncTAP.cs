
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Scripts.Async
{ 
    public class AsyncTAP
    { 
        MakeBreafast breafastMaker;

        public AsyncTAP()
        {
            breafastMaker = new MakeBreafast();
        }

        public void MakeBreafast()
        {
            MakeCoffeAsync();
            MakePorrigeAsync();
        }

        public async void MakeCoffeAsync()
        {
            await Task.Run(() =>
                {
                    breafastMaker.MakeCoffee();
                });
            OnCoffeeMade();
        }

        public async void MakePorrigeAsync()
        {
            await Task.Run(() =>
            {
                breafastMaker.MakePorrige();
            });
            OnPorrigeMade();
        }

        private void OnCoffeeMade()
        {
            Console.WriteLine("咖啡煮好了");
        }

        private void OnPorrigeMade()
        {
            Console.WriteLine("粥煮好了");
        }
    }
}
