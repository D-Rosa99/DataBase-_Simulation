using System;

namespace DataBase
{
    public class Intermediario
    {
        private SqlConnection _sqlDataBase;
        private OracleConnection _oracleDataBase;

        public bool ParameterCheckOut(string DataBaseChoise, string Parameter)
        {
            if (DataBaseChoise == "sql")
            {
                _sqlDataBase = new SqlConnection(Parameter);
                return _sqlDataBase.Validation();
            }
            else
            {
                _oracleDataBase = new OracleConnection(Parameter);
                return _oracleDataBase.Validation();
            }
        }

        public bool Isvalid(string answer)
        {
            if (answer != "sql" && answer != "oracle")
            {
                return false;
            }
            return true;
        }

        public string Input_String()
        {
            string Parameter = Console.ReadLine().ToLower();
            return Parameter;
        }

        public void Open_Close_Control(string Answer)
        {
            while (true)
            {
                string Command = Input_String();

                if (Command == "open")
                {
                    if (Answer == "sql")
                    {
                        _sqlDataBase.OpenConection();
                    }
                    else { _oracleDataBase.OpenConection(); }
                }
                else if (Command == "close")
                {
                    if (Answer == "sql")
                    {
                        _sqlDataBase.CloseConection();
                    }
                    else { _oracleDataBase.CloseConection(); }
                }
                else if (Command == "exit")
                {
                    break;
                }
                else { Console.WriteLine("\nEste no es un comando valido"); }
            }
        }
    }
}
