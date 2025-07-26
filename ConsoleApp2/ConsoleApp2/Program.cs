// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using System.Collections.Generic;
class Program
{
    static List<CommerciaPilot> listCP = new List<CommerciaPilot>();
    static void Main(string[] args)
    {
        while (true)
        {
     
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Them phi cong may bay thuong mai");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Sap xep theo kinh nghiem (giam dan)");
                Console.WriteLine("4. Tim kiem ");
                Console.WriteLine("5. Sua thong tin ");
                Console.WriteLine("6. Xoa thong tin ");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ThemPilot();
                        break;
                    case "2":
                        HienThiDanhSach();
                        break;
                    case "3":
                        SapXep();
                        break;
                    case "4":
                        TimKiem();
                        break;
                    case "5":
                        Sua();
                        break;
                    case "6":
                        Xoa();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
        }

        static void ThemPilot()
        {
            CommerciaPilot cp = new CommerciaPilot();
            cp.Input();

            // Kiểm tra trùng LicenseNumber
            bool isDuplicate = listCP.Any(p => p.licenseNumber == cp.licenseNumber);
            if (isDuplicate)
            {
                Console.WriteLine("Khpng the them: So giay phep da ton tai!");
            }
            else
            {
                listCP.Add(cp);
                Console.WriteLine("Da them phi cong thanh cong!");
            }
        }

        static void HienThiDanhSach()
        {
            Console.WriteLine("\n--- DANH SACH PHI CONG MAY BAY THUONG MAI ---");
            if (listCP.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }

            foreach (var cp in listCP)
            {
                cp.Output();
            }
        }

        static void SapXep()
        {
            listCP = listCP.OrderByDescending(pilot => pilot.experience).ToList();
            Console.WriteLine("Da sap xep danh sach theo kinh nghiem giam dan!");
            //listCP = listCP.OrderBy(pilots => pilots.experience).ToList(); (tang dan)
        }

        static void TimKiem()
        {
            Console.Write("Nhap ten phi cong can tim: ");
            string name = Console.ReadLine();

            var result = listCP.Where(p => p.fullName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine("Ket qua tim kiem:");
                foreach (var p in result)
                {
                    p.Output();
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay phi cong.");
            }
        }

        static void Sua()
        {
            Console.Write("Nhap so giay phep (LicenseNumber) cua phi cong can sua: ");
            string license = Console.ReadLine();

            var pilot = listCP.FirstOrDefault(p => p.licenseNumber == license);

            if (pilot != null)
            {
                Console.WriteLine("Nhap thong tin moi:");
                pilot.Input();
                Console.WriteLine("Cap nhat thanh cong.");
            }
            else
            {
                Console.WriteLine("Khong tim thay phi cong.");
            }
        }

        static void Xoa()
        {
            Console.Write("Nhap so giay phep (LicenseNumber) cua phi cong can xoa: ");
            string license = Console.ReadLine();

            var pilot = listCP.FirstOrDefault(p => p.licenseNumber == license);

            if (pilot != null)
            {
                listCP.Remove(pilot);
                Console.WriteLine("Xoa phi cong thanh cong.");
            }
            else
            {
                Console.WriteLine("Khong tim thay phi cong.");
            }
        }


    }
}


