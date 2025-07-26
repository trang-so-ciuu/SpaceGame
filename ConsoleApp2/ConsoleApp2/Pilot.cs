using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Pilot
    {
        public string fullName { get; set; }
        public int birthYear { get; set; }
        public int experience { get; set; }
        public string licenseNumber { get; set; }
        public string contactInfor { get; set; }

        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            fullName = Console.ReadLine();

            Console.Write(" Nhap nam sinh: ");
            birthYear = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nam kinh nghiem: ");
            experience = int.Parse(Console.ReadLine());

            Console.Write("Nhap so giay phep: ");
            licenseNumber = Console.ReadLine();

            Console.Write("Nhap thong tin lien he: ");
            contactInfor = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"Ten: {fullName}, Nam sinh: {birthYear}, \n" +
                              $"Kinh nghiem: {experience} nam, Giay phep: {licenseNumber}, \n" +
                              $"Lien he: {contactInfor}");
        }
    }
}
