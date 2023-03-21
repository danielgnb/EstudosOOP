using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOP.Extensoes
{
    public static class DateTimeExtensao
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);
            
            if (duracao.TotalHours < 24.0)
            {
                return duracao.TotalHours.ToString("F2", CultureInfo.InvariantCulture) + " horas";
            }
            else
            {
                return duracao.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + " dias";
            }
        }
    }
}
