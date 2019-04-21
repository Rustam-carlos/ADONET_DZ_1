using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ADONET_DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = DESKTOP-OHQR73G;
                                        Initial Catalog = ADO_Net_1_lesson;
                                        Integrated Security = True";
            string sqlExpression = "create table  grup (id int primary key identity, name nvarchar(50) not null)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();  
                Console.WriteLine("Создана база данных");

                sqlExpression = "insert into grup values ('Mike Tyson')";
            
                command = new SqlCommand(sqlExpression, connection);
                int count = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", count);

                sqlExpression = "select * from grup";
            
                command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            Console.Read();

            
            
        }    
    }
}
