using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TestEnvironment.ChatApplication {
    internal class Program {

        public static void Main(String[] args) {
            TcpClient tcpClient = new TcpClient("", 4790);
            Thread thread = new Thread(() => RecieveMessages(tcpClient));
            thread.Start();

            while (tcpClient.Connected) {
                MessageCommunication.SendMessage(tcpClient, Console.ReadLine());
            }


        }

        private static void RecieveMessages(TcpClient tcpClient) {
            while (tcpClient.Connected) {
                String message;
                if ((message = MessageCommunication.ReciveMessage(tcpClient)) != null) {
                    Console.WriteLine(message);
                    if (message.Equals("Goodbye")) {
                        tcpClient.Close();
                        Console.WriteLine("Press enter to quit program");

                        break;
                    }
                }
            }
        }
    }

    internal class MessageCommunication {
        public static string ReciveMessage(TcpClient client) {
            var stream = new StreamReader(client.GetStream(), Encoding.ASCII);
            {
                return stream.ReadLine();
            }
        }

        public static void SendMessage(TcpClient client, string message) {
            var stream = new StreamWriter(client.GetStream(), Encoding.ASCII, 128, true);
            {
                stream.WriteLine(message);
                stream.Flush();
            }
        }
    }
}
