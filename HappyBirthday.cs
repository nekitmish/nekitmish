using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday
{
    class Program
    {
        static int isInt(string strForConvert)
        {
            int var;
            try
            {
                var = Convert.ToInt32(strForConvert);
                return var;
            }
            catch (Exception)
            {
                Console.WriteLine("Ты вывел какую-то бяку");
                Console.ReadKey();
                return 0;
            }
        }

        static void Main(string[] args)
        {
            bool is_run = true;
            while (is_run)
            {
                Console.WriteLine("Привет! Я очень хочу с тобой познакомиться. Как тебя зовут?");
                string name = Console.ReadLine();

                Console.WriteLine($"Очень приятно, {name}! Теперь скажи день своего рождения");
                string day_str = Console.ReadLine();
                int day = isInt(day_str);
                if ((day <= 0) | (day > 31))
                {
                    Console.WriteLine("Ты втираешь мне какую-то дичь. Попробуй еще раз");
                    continue;
                }

                Console.WriteLine("Отлично, а теперь месяц");
                string month_str = Console.ReadLine();
                int month = isInt(month_str);
                if ((month <= 0) | (month > 12))
                {
                    Console.WriteLine("Ты втираешь мне какую-то дичь. Попробуй еще раз");
                    continue;
                }

                Console.WriteLine("Превосходно, осталось самое важное -год!");
                string year_str = Console.ReadLine();
                int year = isInt(year_str);
                if ((year <= 0) | (!DateTime.IsLeapYear(year) & (day > 28) & (month == 2)))
                {
                    Console.WriteLine("Ты втираешь мне какую-то дичь. Попробуй еще раз");
                    continue;
                }

                DateTime datenow = DateTime.Now;
                DateTime birthdate = new DateTime(year, month, day);
                TimeSpan t = datenow - birthdate;
                int howold = Convert.ToInt32(Math.Floor((t.TotalDays / 365)));
                if (howold >= 0)
                {
                    Console.WriteLine($"Тебя зовут {name}. Тебе {howold} полных лет. Очень рад с тобой позакомиться");
                }
                else
                {
                    Console.WriteLine($"Тебя зовут {name}.Ты родишься через {-howold-1} лет. Повзрослеешь - позвони");
                }
                is_run = false;
   
            }
            Console.ReadKey();
        }
    }
}
