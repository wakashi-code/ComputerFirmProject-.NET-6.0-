using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ComputerFirmProject_.NET_6._0_
{
    public class ComputerFirmDb
    {
        private const string CREATE_TABLE_COMPUTER_FIRM_COMMAND = "CREATE TABLE IF NOT EXISTS COMPUTER_FIRM_WORKERS(_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, FirstName TEXT NOT NULL, LastName TEXT NOT NULL, Age INTEGER NOT NULL)";
        private const string CREATE_TABLE_USERS_COMMAND = "CREATE TABLE IF NOT EXISTS USERS(_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Login TEXT NOT NULL, Password TEXT NOT NULL)";
        private const string CREATE_TABLE_COMPUTER_COMPONENTS_COMMAND = "CREATE TABLE IF NOT EXISTS COMPUTER_COMPONENTS(_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, ComponentName TEXT NOT NULL, Type TEXT NOT NULL, Price INTEGER NOT NULL)";

        private const string CREATE_INSERT_COMMAND_TO_INSERT_FIRST_WORKER_IN_COMPUTER_FIRM_DB = "INSERT INTO COMPUTER_FIRM_WORKERS(FirstName, LastName, Age) VALUES ('Андрей', 'Романов', 24)";
        private const string CREATE_INSERT_COMMAND_TO_INSERT_SECOND_WORKER_IN_COMPUTER_FIRM_DB = "INSERT INTO COMPUTER_FIRM_WORKERS(FirstName, LastName, Age) VALUES ('Алексей', 'Ивахненко', 31)";
        private const string CREATE_INSERT_COMMAND_TO_INSERT_THIRD_WORKER_IN_COMPUTER_FIRM_DB = "INSERT INTO COMPUTER_FIRM_WORKERS(FirstName, LastName, Age) VALUES ('Оксана', 'Милонова', 26)";

        private const string CREATE_INSERT_COMMAND_TO_INSERT_ADMIN_IN_USERS = "INSERT INTO USERS(Login, Password) VALUES ('Admin', 'Admin')";

        private const string CREATE_INSERT_COMMAND_TO_INSERT_FIRST_PROCESSOR_IN_COMPUTER_COMPONENTS_DB = "INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ('AMD Ryzen 5 3400G, AM4, OEM', 'Процессор', '8500 руб.')";
        private const string CREATE_INSERT_COMMAND_TO_INSERT_SECOND_PROCESSOR_IN_COMPUTER_COMPONENTS_DB = "INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ('Процессор Intel Core i7 12700KF, LGA 1700, OEM', 'Процессор', '27990 руб.')";


        private const string CREATE_INSERT_COMMAND_TO_INSERT_FIRST_MEMORY_IN_COMPUTER_COMPONENTS_DB = "INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ('Kingston Fury Renegade KF432C16RB2AK8/256 DDR4 - 8x 32ГБ 3200МГц, DIMM, Ret', 'ОЗУ', '89090 руб.')";
        private const string CREATE_INSERT_COMMAND_TO_INSERT_SECOND_MEMORY_IN_COMPUTER_COMPONENTS_DB = "INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ('Kingston Fury Beast Black KF432C16BBK2/16 DDR4 - 2x 8ГБ 3200МГц, DIMM, Ret, DIMM, Ret', 'ОЗУ', '4890 руб.')";

        private const string CREATE_INSERT_COMMAND_TO_INSERT_FIRST_VIDEOCARD_IN_COMPUTER_COMPONENTS_DB = "INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ('Gigabyte NVIDIA GeForce RTX 4070TI GV-N407TGAMING OC-12GD 12ГБ GDDR6X', 'Видеокарта', '118160 руб.')";
        private const string CREATE_INSERT_COMMAND_TO_INSERT_SECOND_VIDEOCARD_IN_COMPUTER_COMPONENTS_DB = "INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ('Palit NVIDIA GeForce RTX 3060 PA-RTX3060 DUAL 12G 12ГБ Dual, GDDR6, LHR, Ret', 'Видеокарта', '34990 руб.')";

        public const string PATH_TO_DATABASE = "Data Source=ComputerFirm.db";
        public SqliteCommand command = new SqliteCommand(PATH_TO_DATABASE);
        public SqliteConnection connection = new SqliteConnection(PATH_TO_DATABASE);

        public ComputerFirmDb()
        {
            connection.Open();
            command.Connection = connection;
            InitializeTables();
            InitializeStartCommands();
        }

        private void InitializeTables()
        {
            command.CommandText = CREATE_TABLE_COMPUTER_FIRM_COMMAND;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_TABLE_USERS_COMMAND;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_TABLE_COMPUTER_COMPONENTS_COMMAND;
            command.ExecuteNonQuery();
        }
        private void InitializeStartCommands()
        {
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_FIRST_WORKER_IN_COMPUTER_FIRM_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_SECOND_WORKER_IN_COMPUTER_FIRM_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_THIRD_WORKER_IN_COMPUTER_FIRM_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_ADMIN_IN_USERS;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_FIRST_PROCESSOR_IN_COMPUTER_COMPONENTS_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_FIRST_MEMORY_IN_COMPUTER_COMPONENTS_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_FIRST_VIDEOCARD_IN_COMPUTER_COMPONENTS_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_SECOND_PROCESSOR_IN_COMPUTER_COMPONENTS_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_SECOND_MEMORY_IN_COMPUTER_COMPONENTS_DB;
            command.ExecuteNonQuery();
            command.CommandText = CREATE_INSERT_COMMAND_TO_INSERT_SECOND_VIDEOCARD_IN_COMPUTER_COMPONENTS_DB;
            command.ExecuteNonQuery();
        }

        public void DeleteWorkerFromComputerFirmDB(string name) 
        {
            string sqlExpression = $"DELETE FROM COMPUTER_FIRM_WORKERS WHERE NAME={name}";
            command.CommandText = sqlExpression;
            command.ExecuteNonQuery();
        }

        public void AddWorkerToComputerFirmDB(string firstName, string lastName, string age)
        {
            string sqlExpression = $"INSERT INTO COMPUTER_FIRM_WORKERS(FirstName, LastName, Age) VALUES ({firstName}, {lastName}, {age})";
            command.CommandText = sqlExpression;
            command.ExecuteNonQuery();
        }

        public void AddComputerComponentToDB(string componentName, string type, string price)
        {
            string sqlExpression = $"INSERT INTO COMPUTER_COMPONENTS(ComponentName, Type, Price) VALUES ({componentName}, {type}, {price})";
            command.CommandText = sqlExpression;
            command.ExecuteNonQuery();
        }

        public void DeleteComputerComponentToDB(string componentName)
        {
            string sqlExpression = $"DELETE FROM COMPUTER_COMPONENTS WHERE ComponentName={componentName}";
        }

        public void RegisterNewUserInUsersTable(string login, string password)
        {

        }

    }
}