using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB6__task3_
{
    interface IHasInfo
    {
        void ShowInfo();
    }
    interface IServices 
    {
        void ForUser();
        int Cost { get; }

    }

    abstract class Services : IHasInfo, IServices
    {
        
        public abstract int Cost { get; }

        public abstract void ForUser();
        

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Цена: {Cost}");
        }
    }

    class Sale : Services
    {
        public override int Cost => 1950;
        public override void ForUser()
        {
            Console.WriteLine("Эта услуга дает возможность продажи нужной информации!");
        }

    }
    class Consultution : Services
    {
        public override int Cost { get { return 1020; } }
        public override void ForUser()
        {
            Console.WriteLine("Эта услуга дает возможность проконсультироватся!");
        }

    }

    class Buing : Services
    {
        public override int Cost => 3065;

        public override void ForUser()
        {
            Console.WriteLine("Эта услуга дает возможность покупки!");
        }
    }

    class Company : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Больше услуг нет!");
        }
    }
    class User
    {
        public void ForUser(IServices services)
        {
            services.ForUser();
        }
        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Services[] ser = { new Sale(), new Consultution(), new Buing() };
            foreach (var choice in ser)
            {
                user.CheckInfo(choice);
                user.ForUser(choice);
                Console.WriteLine();
            }
            user.CheckInfo(new Company());
        }
    }
}
