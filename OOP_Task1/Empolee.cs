using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1
{
    public class Employee
    {
        short id;
        string name;
        string surname;
        byte age;
        string workplace;
        string position;
        short salary;
        string country;
        public short Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public byte Age { get { return age; } set { age = value; } }
        public string Workplace { get { return workplace; } set { workplace = value; } }
        public string Position { get { return position; } set { position = value; } }
        public short Salary { get { return salary; } set { salary = value; } }
        public string Country { get { return "England"; } }
        public void GetInfo1()
        {
            Console.WriteLine($"{this.Id = 2}\n{this.Name ="John"}\n{this.Surname ="Carter"}\n{this.Age =26}\n{this.Workplace ="IT software engineering school"}\n{this.Position ="IT teacher"}\n{this.Salary =2000}\n{this.Country}\n");
        }
        public void GetInfo2()
        {
            Console.WriteLine($"{this.Id = 3}\n{this.Name = "Alex"}\n{this.Surname = "Tampsey"}\n{this.Age = 28}\n{this.Workplace = "Data School"}\n{this.Position = "Data engineer"}\n{this.Salary = 1200}\n{this.Country}");
        }

    }
}
