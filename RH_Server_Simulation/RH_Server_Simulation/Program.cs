using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RH_Server_Simulator {
    internal class Program {
        public static void Main(string[] args) {
            TcpListener PatientListner = new TcpListener(IPAddress.Any, 4789);
            TcpListener DoctorListner = new TcpListener(IPAddress.Any, 4790);
            PatientListner.Start();
            DoctorListner.Start();

            Console.WriteLine("Starting up server and waiting for connections.....");

            while (true) {
                if (PatientListner.Pending()) {
                    TcpClient Patient = PatientListner.AcceptTcpClient();
                    MessageCommunication.SendMessage(Patient.GetStream(), "Welcome Patient");
                    Console.WriteLine($"Welcome Patient");
                    Thread PatientThread = new Thread(async () => HandleClient(Patient));
                    PatientThread.Start();
                }
                if (DoctorListner.Pending()) {
                    TcpClient doctor = DoctorListner.AcceptTcpClient();
                    MessageCommunication.SendMessage(doctor.GetStream(), "Enter Login Data");
                    Console.WriteLine($"Enter Login Data");
                    Thread doctorThread = new Thread(async () => HandleClient(doctor));
                    doctorThread.Start();
                }
            }
        }

        private static void HandleClient(TcpClient tcpClient) {
            NetworkStream networkStream = tcpClient.GetStream();
            while (tcpClient.Connected) {
                String R_message;
                String S_message;
                if ((R_message = MessageCommunication.ReceiveMessage(networkStream)) == null) {
                    continue;
                }

                Console.WriteLine($"{R_message}");
                S_message = Console.ReadLine();
                MessageCommunication.SendMessage(networkStream, S_message);
            }
        }
    }

    public class MessageCommunication {
        public static string ReceiveMessage(NetworkStream networkStream) {
            try {
                var stream = new StreamReader(networkStream, Encoding.ASCII, true, 128);
                String line = stream.ReadLine();
                return line;
            } catch (IOException exception) {
                return "Connection With Host Was Lost";
            }
        }

        public static void SendMessage(NetworkStream networkStream, string message) {
            try {
                var stream = new StreamWriter(networkStream, Encoding.ASCII, 128, true);
                stream.WriteLine(message);
                stream.Flush();
            } catch (IOException exception) {
                return;
            }
        }
    }
}
