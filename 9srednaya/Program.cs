using System;
using System.Linq;
namespace _9srednaya
{
    class Program
    {
        struct Plan
        {
            public DateTime data;
            public string fio;
            public string dolg;
            public DateTime prihod;
            public DateTime yhod;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько проектов");
            int k = int.Parse(Console.ReadLine());
            Plan[] plans = new Plan[k];
            for (int i = 0; i < plans.Length; i++)
            {
                Console.WriteLine("Дата:");
                plans[i].data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("ФИО сотрудника:");
                plans[i].fio = Console.ReadLine();
                Console.WriteLine("Должность:");
                plans[i].dolg = Console.ReadLine();
                Console.WriteLine("Время прихода:");
                plans[i].prihod = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(plans[i].prihod.TimeOfDay);
                Console.WriteLine("Время ухода:");
                plans[i].yhod = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(plans[i].yhod.TimeOfDay);
                
            }
            foreach (Plan item in plans)
            {
                DateTime ra = Convert.ToDateTime(Console.ReadLine());//не понял как сделать

                if (item.prihod > ra)
                {
                    Console.WriteLine(item.data + ", " + item.fio + ", " + item.dolg + ", " + item.prihod + ", " + item.yhod);
                }
            }
        }
    }
}
