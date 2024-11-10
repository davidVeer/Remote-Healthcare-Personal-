using RH_Doctor.Connectivity;
using System.Text.RegularExpressions;

namespace RH_Doctor.StateMachine {

    internal class Connect(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            if (ActionCommand.Equals("Connect")) {
                protocol.ConnectToServer("192.168.0.131");
            }
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            if (RecievedMessage.Equals(ValidMessages.d_enterLogin)) {
                protocol.ChangeActiveState(new Login(protocol));
                return;
            }
        }
    }

    internal class Login(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string loginMessage) {
            Regex JsonRegex = new Regex("^\\{.+\\}$");
            if (JsonRegex.IsMatch(loginMessage)) {
                MessageCommunication.SendMessage(protocol.networkStream, loginMessage);
            }


        }

        public override async Task RespondToMessage(string RecievedMessage) {
            if (RecievedMessage.Equals(ValidMessages.d_correctLogin)) {
                protocol.ChangeActiveState(new EnterCommand(protocol));
                //TODO: switch to Overview Form
                return;
            }
        }
    }

    internal class EnterCommand(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

    internal class Subscribe(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

    internal class Unsubscribe(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

    internal class StartSession(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

    internal class EndSession(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

    internal class SendData(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

    internal class FethData(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
        }
    }

}
