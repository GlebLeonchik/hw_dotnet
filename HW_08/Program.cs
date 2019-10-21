using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08
{

    class Airport
    {
    }

    class CheckIn : Airport
    {
        const int baggageWeightmax = 10;

        string ticket;
        int baggageWeight;
        public string name;
                
        public string NameInfo()
        {            
            Console.WriteLine("Введите свою Фамилию и Имя");
            name = Console.ReadLine();
            return name;
        }

        public void Ticket(string txt)
        {
            ticket = txt;
            Console.WriteLine("Ваш билет номер " + ticket);
        }

        public void Ticket()
        {
            ticket = "E-ticket";
            Console.WriteLine("У вас электронный билет");
        }

        public void BaggageWeight()
        {
            Console.WriteLine("Взвесьте ваш багаж");
            baggageWeight = Convert.ToInt32(Console.ReadLine());
            if (baggageWeight > baggageWeightmax)
            {
                Console.WriteLine("Положите ваш багаж на транспортную ленту");
            }
            else
            {
                Console.WriteLine("Вы можете взять свой багаж с собой");
            }
        }
    }

    class SecurityControl : Airport
    {
        const bool accept = true;

        public void SecControl(bool status)
        {
            Console.WriteLine("Пройдите через рамку металлоискателя");
            if (bool.Equals(accept, status))
            {
                Console.WriteLine("возьмите вашу ручную кладь и идите в зону ожидания посадки");
            }
            else
            {
                Console.WriteLine("Пройдёмте в комнату для выяснения обстоятельств");
            }
           
        }
    }    
   
    class DutiFreeZone:CheckIn
    {
        public void LastCheck(string txt)
        {
            CheckIn checkIn1 = new CheckIn();
            string thisname;
            string checkname = txt;
            Console.WriteLine("Ваше Имя и Фамилия");
            thisname = Console.ReadLine();
            if(checkname.Equals(thisname))
            {
                Console.WriteLine("Добро пожаловать на борт!");
            }
            else
            {
                Console.WriteLine("Это не ваш рейс!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CheckIn checkIn = new CheckIn();
            SecurityControl securityControl = new SecurityControl();
            DutiFreeZone dutiFreeZone = new DutiFreeZone();
            checkIn.NameInfo();
            string txt = checkIn.name;
            checkIn.Ticket();
            Console.WriteLine();
            securityControl.SecControl(true);
            Console.WriteLine();
            dutiFreeZone.LastCheck(txt);
            Console.ReadKey();
        }
    }
}
