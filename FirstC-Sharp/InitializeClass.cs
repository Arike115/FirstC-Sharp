using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Sharp
{
    public static class InitializeClass
    {
        public static string ChangeFirstLetter(this string firstLetter)
        {
            if(firstLetter.Length > 0)
            {
                char[] chararray = firstLetter.ToCharArray();
                chararray[0] = char.IsUpper(chararray[0]) ? char.ToLower(chararray[0]) 
                    : char.ToUpper(chararray[0]);
                return new string(chararray);
            }
            return firstLetter;
        }
    }
}
