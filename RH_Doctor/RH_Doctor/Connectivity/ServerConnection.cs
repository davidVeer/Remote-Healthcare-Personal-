using RH_Doctor.ActiveData;
using RH_Doctor.StateMachine;
using System.Net.Sockets;

namespace RH_Doctor.Connectivity {
    internal class ServerConnection {
        public TcpClient DoctorClient { get; private set; }
        public NetworkStream networkStream { get; private set; }
        public PatientMonitoring PatientLog { get; set; }
        private DoctorStateAbstract activeState;

        public ServerConnection() {
            this.activeState = new Connect(this);
            PatientLog = new PatientMonitoring();
            this.activeState.PerformAction("Connect");
        }

        public async Task ReadMessagesAsync() {
            throw new NotImplementedException();
        }

        public void ConnectToServer(String IP_Adress) {
            DoctorClient = new TcpClient(IP_Adress, 4790);
            this.networkStream = DoctorClient.GetStream();
        }

        public void ChangeActiveState(DoctorStateAbstract newState) {
            this.activeState = newState;
        }
    }
}
