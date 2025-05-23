﻿using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Consumer
{
    public class Reciever
    {
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTest", false, false, false, null);
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea)
                =>
                {
                        var body = ea.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine($"Recieved meassage{message}...");
                };
                channel.BasicConsume("BasicTest", true, consumer);
                Console.WriteLine("press enter to continue");
                Console.ReadLine();
            }
        }
    }
}