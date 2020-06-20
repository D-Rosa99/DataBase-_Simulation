using System;

namespace DataBase
{
    public abstract class DbConnection
    {
        public string _ConnectionString { get; set; }
        public string _formatString { get; set; }
        
        public DbConnection(string Connection)
        {
            this._ConnectionString = Connection;
        }


        public abstract void OpenConection();

        public abstract void CloseConection();


        public bool Validation()
        {
            if (_formatString == _ConnectionString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
