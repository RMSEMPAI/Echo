using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anketa();
            Console.ReadKey();
        }
        static (string Name, string LastName, double Age, string[] Pets,string[] FavColors)EnterUser()
        {
            (string Name, string LastName, double Age, string[]Pets, string[] FavColors) User;
            Console.WriteLine("Как вас зовут?");
            User.Name= Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            User.LastName= Console.ReadLine();
            string age;
            int num;
            do
            {
                Console.WriteLine("Введите ваш возраст?");
                age = Console.ReadLine();
            } while (CheckNum(age, out num));
            User.Age = num;
            int countPets = HasPet();
            User.Pets = Pets(countPets);
            foreach (var i in User.Pets)
            {
                Console.WriteLine(i);
            }
            string count;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
                count = Console.ReadLine();
                
            }while(CheckNum(count, out num));
            User.FavColors = FavColors(num);
            foreach(var i in User.FavColors)
            {
                Console.WriteLine(i);
            }
            return User;

        }
        static int HasPet()
        {
            Console.WriteLine("Есть ли у вас питомцы?(Да или нет)");
            string HasPets = Console.ReadLine();
            if ((HasPets == "Да") || (HasPets == "да"))
            {
                string count;
                int num;
                do
                {
                    Console.WriteLine("Введите количество питомцев");
                    count = Console.ReadLine();
                } while (CheckNum(count, out num));
                return num;

            }
            else if (HasPets == "Нет"||(HasPets == "нет"))
            {
                Console.WriteLine("Самое время завести себе друга");
                return 0;
            }
            else
            {
                Console.WriteLine("Ответ должен быть да или нет");
                Back();
                return 0;
            }
        }
        static void Back()
        {
            HasPet();
        }
        
        static string [] Pets (int count)
        {
            var result = new string[count];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Как зовут питомца {0}?", i + 1);
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static string[] FavColors (int CountColors)
        {
            var result = new string[CountColors];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Какой ваш любимый цвет под номером {0}",i+1);
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static bool CheckNum(string Number, out int num)
        {
            if (int.TryParse(Number, out int intnum))
            {
                if (intnum > 0)
                {
                    num = intnum;
                    return false;
                }
            }
            {
                num = 0;
                Console.WriteLine("Введити коректное число большее 0!!!");
                return true;

            }
        }
        static void Anketa()
        {
            Console.WriteLine("Информация о пользователе:{0}", EnterUser());
        }
    }
}
