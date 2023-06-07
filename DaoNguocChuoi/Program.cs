using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoNguocChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi kí tự: ");
            string s1 = Console.ReadLine();
            string s1_daoNguoc = DaoNguoc.DaoNguocChuoi_ByFor(s1);
            Console.WriteLine("\nDao nguoc theo FOR: " + s1_daoNguoc);

            string s1_daoNguoc2 = DaoNguoc.DaoNguocChuoi_By_ArrayReverse(s1);
            Console.WriteLine("Dao nguoc theo Array.Reverse: " + s1_daoNguoc2);
        }
    }
}
