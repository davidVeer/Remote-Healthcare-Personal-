using RH_Doctor.ActiveData;
using RH_Doctor.StateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RH_Doctor.Connectivity {
    internal class ServerConnection {
        public readonly TcpClient doctorClient;
        private PatientMonitoring PatientLog;
        private DoctorStateAbstract activeState;

        public ServerConnection() {
            throw new NotImplementedException();
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
