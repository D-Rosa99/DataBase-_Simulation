using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var Begin = new Intermediario();

            while (true)
            {
                Console.Write("\nEscribe con cual base de datos te quieres conectar (Sql o Oracle)  ");
                var Answer = Begin.Input_String();

                if (Begin.Isvalid(Answer))
                {
                    Console.Write("\nEscribe los parametros que corresponda a esa base de datos ");

                    string Parameter= Begin.Input_String();

                    if (Begin.ParameterCheckOut(Answer, Parameter))
                    {
                        Console.WriteLine("\nLa Conexion se ha validado Correctamente");
                        Console.WriteLine("\nEscribe 'Open' para abrir la conexion, 'Close' para cerrarla y 'Exit' para salir ");

                        Begin.Open_Close_Control(Answer);
                    }
                    else{Console.WriteLine("\nEl parametro pasado no es valido");}

                }
                else {Console.WriteLine("\nEse tipo de base datos no esta disponible, las unica disponible son Sql y Oracle");}
            }


        }
    }
}
