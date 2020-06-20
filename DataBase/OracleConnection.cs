using System;

namespace DataBase
{
    public class OracleConnection: DbConnection
    {
        private readonly string _formConnectionOracle = "Server:Oracle Password:Activo";
        private bool _switch= false;

        public OracleConnection(string Connection) : base(Connection)
        {
            this._formConnectionOracle = _formatString;
        }

        public override void OpenConection()
        {
            if (_switch == true)
            {
                Console.WriteLine("\nLa conexion ya ha sido abierta anteriormente, cierrela para despues poder abrirla de nuevo");
            }
            else
            {
                Console.WriteLine("\nLa conexion con Oracle DataBase ha sido abierta");
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
                Console.WriteLine("\nLa conexion con Oracle DataBase ha sido cerrada");
                _switch = false;
            }
            
  
        }

    }
}
