using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp
{
    delegate int Numberchanger(int n);
   public class Logic
    {
       public static int num = 10;//field
        

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int SubNum(int p)
        {
            num -= p;
            return num;
        } 
        public static int MulNum(int p)
        {
            num *= p;
            return num;
        }
    }
}
