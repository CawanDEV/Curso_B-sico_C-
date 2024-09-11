using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeCasoPessoa
{
    static class Extesions
    {
        public static bool HasOnlyDigits(this string valor)
        {
            const string digitos = "0123456789";
            foreach (char c in digitos)
            {
                if(!digitos.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
