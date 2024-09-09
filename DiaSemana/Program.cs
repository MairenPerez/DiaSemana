using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    internal class Program
    {
        enum DiaSemana
        {
            Lunes = 1,
            Martes = 2,
            Miércoles = 3,
            Jueves = 4,
            Viernes = 5,
            Sábado = 6,
            Domingo = 7
        }

        static void Main(string[] args)
        {
            string diaSemana;
            Console.WriteLine("¿Qué día de la semana es hoy?");
            diaSemana = Console.ReadLine();

            int numeroDia = DevuelveNumeroDia(diaSemana);
            Console.WriteLine("El número del día de la semana es: " + numeroDia);

            Console.ReadLine();
        }

        static int DevuelveNumeroDia(string dia)
        {
            if (Enum.TryParse(dia, out DiaSemana diaSemana))
            {
                return (int)diaSemana;
            }
            else
            {
                return -1;
            }
        }
    }
}
