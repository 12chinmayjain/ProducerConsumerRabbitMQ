using RabbitMQ.Client;
using System.Text;

namespace ConsoleApp1
{
    internal class Sender
    {
        static void Main(string[] args)
        {
           var factory = new ConnectionFactory() { HostName = "localhost"};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);

                string message = "Getting started with .net core rabbitMQ";
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish("","BasicTest",null,body);
                Console.WriteLine("Sent Message",message);
            }
            Console.WriteLine("Press [enter] to exit the sender app...");
            Console.WriteLine();
        }
    }
}
