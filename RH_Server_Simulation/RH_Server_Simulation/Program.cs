using System.Net;
using System.Net.Sockets;

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
                    Thread PatientThread = new Thread(async () => HandleClient(Patient));
                    PatientThread.Start();
                }
                if (DoctorListner.Pending()) {
                    TcpClient doctor = DoctorListner.AcceptTcpClient();
                    Thread doctorThread = new Thread(async () => HandleClient(doctor));
                    doctorThread.Start();
                }
            }
        }

        private static void HandleClient(TcpClient tcpClient) {
            while (tcpClient.Connected) {
                throw new Exception("no message functionality Yet");
            }
        }
    }
}
