using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Scripts.Async
{
    public class Coffee
    {

    }

    public class Egg
    {

    }

    public class Bacon
    {

    }

    public class Toast
    {

    }

    public class Juice
    {

    }

    class ComplicatedBreakfastMaker
    {
        public async void MakeBreafast()
        {
            var startTime = DateTime.Now;
            CookLog("");
            Coffee cup = PourCoffee();
            CookLog("咖啡好了");

            var eggTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = ToastBreadAsync(2);

            Egg egg = await eggTask;
            CookLog("鸡蛋好了");

            Bacon bacon = await baconTask;
            CookLog("培根好了");

            Toast toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            CookLog("吐司好了");

            Juice oj = PourOJ();
            CookLog("果汁就绪");
            CookLog("早餐好了！");
            Console.WriteLine("共计花费时间：" + (DateTime.Now-startTime));
        }

        private void CookLog(string msg)
        {
            if(!string.IsNullOrEmpty(msg))
                Console.WriteLine(msg);
            Console.WriteLine("当前时间：" + DateTime.Now);
        }

        private Juice PourOJ()
        {

            return new Juice();
        }

        private void ApplyJam(Toast toast)
        {
            Console.WriteLine("把果酱涂到吐司上");
        }

        private void ApplyButter(Toast toast)
        {
            Console.WriteLine("把黄油加到吐司上");
        }

        private async Task<Toast> ToastBreadAsync(int v)
        {
            for (int i =0;i<v;i++)
            {
                await Task.Delay(2000);
                Console.WriteLine("把一块面包放到吐司机里");
            }
            Console.WriteLine("开始做吐司");
            await Task.Delay(3000);
            Console.WriteLine("把吐司从吐司机里拿出来");
            return new Toast();
        }

        private async Task<Bacon> FryBaconAsync(int v)
        {
            Console.WriteLine("开始煎培根");          
            await Task.Delay(5000);
            Console.WriteLine("把培根放到盘子");
            return new Bacon();
        }

        private async Task<Egg> FryEggsAsync(int v)
        {
            Console.WriteLine("开始煎鸡蛋");
            await Task.Delay(2000);
            Console.WriteLine("把鸡蛋放到盘子");
            return new Egg();
        }

        private Coffee PourCoffee()
        {
            Console.WriteLine("倒咖啡");
            return new Coffee();
        }
    }
}
