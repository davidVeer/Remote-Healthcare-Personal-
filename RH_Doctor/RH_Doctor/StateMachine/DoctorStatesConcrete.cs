using RH_Doctor.Connectivity;

namespace RH_Doctor.StateMachine {

    internal class Connect(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            if (ActionCommand.Equals("Connect")) {
                protocol.ConnectToServer("192.168.0.131");
            }
        }

        public override async Task RespondToMessage(string RecievedMessage) {

        }
    }

    internal class Login(ServerConnection protocol) : DoctorStateAbstract(protocol) {

        public override void PerformAction(string ActionCommand) {
            throw new NotImplementedException();
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            throw new NotImplementedException();
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
