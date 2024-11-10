using RH_Doctor.Connectivity;
using System.Text.RegularExpressions;

namespace RH_Doctor.StateMachine {
    internal abstract class DoctorStateAbstract {
        protected ServerConnection protocol;
        protected readonly Regex JsonRegex = new Regex("^\\{.+\\}$");
        protected readonly List<String> names;

        public DoctorStateAbstract(ServerConnection protocol) {
            this.protocol = protocol;
            this.names = [];
        }

        protected DoctorStateAbstract(ServerConnection protocol, List<string> names){
            this.protocol = protocol;
            this.names = names;
        }

        public abstract void PerformAction(String ActionCommand);

        public abstract Task RespondToMessage(String RecievedMessage);
    }
}
