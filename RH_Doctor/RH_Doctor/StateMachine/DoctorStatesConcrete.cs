using RH_Doctor.Connectivity;
using System.Text.Json;
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

        public override void PerformAction(string nextCommand) {
            MessageCommunication.SendMessage(protocol.networkStream, nextCommand);
        }

        public override async Task RespondToMessage(string RecievedMessage) {
            DoctorStateAbstract nextState;

            if (JsonRegex.IsMatch(RecievedMessage)) {
                //TODO: Should set RecievedMessage to message Extracted From Json
            }


            switch (RecievedMessage) {
                case ValidMessages.d_startSessionResponse:
                    nextState = new StartSession(protocol);
                    break;
                case ValidMessages.d_endSessionResponse:
                    nextState = new EndSession(protocol);
                    break;
                case ValidMessages.d_subscribeResponse:
                    nextState = new Subscribe(protocol);
                    break;
                case ValidMessages.d_unsubscribeResponse:
                    nextState = new Unsubscribe(protocol);
                    break;
                case ValidMessages.d_sendDataResponse:
                    nextState = new SendData(protocol);
                    break;
                case ValidMessages.d_retrieveDataResponse:
                    nextState = new FethData(protocol);
                    break;
                default:
                    return;
            }

            protocol.ChangeActiveState(nextState);
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
