using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class CommerciaPilot : Pilot 
    {
        public string airline {  get; set; }
        public string aircraftType {  get; set; }
        public void Input()
        {
            base.Input();
            Console.Write("Nhap hang hang khong: ");
            airline = Console.ReadLine();

            Console.Write("Nhap loai may bay: ");
            aircraftType = Console.ReadLine();
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine($"  Hang: {airline}, Loai may bay: {aircraftType}");
        }
    }
}
