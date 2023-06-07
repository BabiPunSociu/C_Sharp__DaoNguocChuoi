using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoNguocChuoi
{
    internal class DaoNguoc
    {
        public static string DaoNguocChuoi_ByFor(string s)
        {
            string result = string.Empty;
            for(int i = s.Length-1; i >=0; i--)
            {
               result += s[i];
            }
            return result;
        }

        public static string DaoNguocChuoi_By_ArrayReverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string result = new string(arr);
            return result;
        }
    }
}
