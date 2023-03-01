using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BDay { get; set; }
        private char sex;
        public char Sex
        {
            get { return sex; }
            set { if (value == 'М' | value == 'Ж') sex = value; }
        }
        public Person() { }

        public override string ToString()
        {
            return Name + " " + Surname + " " + BDay + " " + sex;
        }
        public void Read()
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения (гггг-мм-дд): ");
            BDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите пол(М/Ж): ");
            sex = char.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {Name} Фамилия: {Surname} Возраст: {Age(BDay)} Пол: {sex}");
        }
        public int Age(DateTime BDay)
        {
            int age = DateTime.Now.Year - BDay.Year;
            if (DateTime.Now.Day < BDay.Day)
            {
                if (DateTime.Now.Month < BDay.Month)
                {
                    age--;
                }
            }
            return age;
        }
    }
}
