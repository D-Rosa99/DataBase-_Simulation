using System;

namespace DataBase
{
    public class SqlConnection : DbConnection
    {
        private readonly string _formConnectionSql = "hola";
        private bool _switch = false;

        public SqlConnection(string Connection) : base(Connection)
        {
            _formatString = _formConnectionSql;
        }

        public override void OpenConection()
        {
            if (_switch == true)
            {
                Console.WriteLine("\nLa conexion ya ha sido abierta anteriormente, cierrela para despues poder abrirla de nuevo");
            }
            else
            {
                Console.WriteLine("\nLa conexion con Sql DataBase ha sido abierta");
                _switch = true;
            }
        }

        public override void CloseConection()
        {
            if (_switch == false)
            {
                Console.WriteLine("\nNo puedes cerrar la conexion sin antes abrirla");
            }
            else
            {
                Console.WriteLine("\nLa conexion con Sql DataBase ha sido cerrada");
                _switch = false;
            }
        }
        
    }
}
