using RH_Doctor.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RH_Doctor.StateMachine {
    internal abstract class DoctorStateAbstract {
        protected ServerConnection protocol;
        protected readonly Regex JsonRegex = new Regex("^\\{.+\\}$");

        public DoctorStateAbstract(ServerConnection protocol) {
            this.protocol = protocol;
        }

        public abstract void PerformAction(String ActionCommand);

        public abstract Task RespondToMessage(String RecievedMessage);
    }
}
