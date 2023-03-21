using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Extensoes
{
    public static class StringExtensao
    {
        public static string Cut(this String thisObj, int contador)
        {
            if (thisObj.Length <= contador)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, contador) + "...";
            }
        }
    }
}
