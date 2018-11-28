using System;

namespace PersonInfomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Joah", 24, 12345, 100000);
            Console.WriteLine("MyInfo:");
            Console.WriteLine("name:{0}, level:{1}, hp:{2}, exp:{3}", person.Name, person.Level, person.Hp, person.Exp);
        }

        public class Person
        {
            string m_name;
            int m_level;
            int m_exp;
            int m_hp;
        
            public Person(string name, int level, int exp, int hp)
            {
                Name = name;
                Level = level;
                Exp = exp;
                Hp = hp;
            }

            public string Name { get => m_name; set => m_name = value; }
            public int Level { get => m_level; set => m_level = value; }
            public int Exp { get => m_exp; set => m_exp = value; }
            public int Hp { get => m_hp; set => m_hp = value; }
        }
    }
}
