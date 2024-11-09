using RH_Doctor.ActiveData;
using RH_Doctor.StateMachine;
using System.Net.Sockets;

namespace RH_Doctor.Connectivity {
    internal class ServerConnection {
        public readonly TcpClient doctorClient;
        private PatientMonitoring PatientLog;
        private DoctorStateAbstract activeState;

        public ServerConnection() {

        }

        public async Task ReadMessagesAsync() {
            throw new NotImplementedException();
        }

        public void ConnectToServer() {
            throw new NotImplementedException();
        }

        public void ChangeActiveState(DoctorStateAbstract newState) {
            throw new NotImplementedException();
        }
    }
}
