using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RH_Doctor.Connectivity {
    internal class MessageCommunication {

        public static void SendMessage(NetworkStream sendingStream, String MessageToSend) {
            try {
                var stream = new StreamWriter(sendingStream, Encoding.ASCII, 128, true);
                stream.WriteLine(MessageToSend);
                stream.Flush();
            } catch (IOException exception) {
                return;
            }
        }

        public static String RecieveMessage(NetworkStream recievingStream) {
            try {
                var stream = new StreamReader(recievingStream, Encoding.ASCII, true, 128);
                return stream.ReadLine(); ;
            } catch (IOException exception) {
                return "Connection With Host Was Lost";
            }
        }
    }

    internal static class ValidMessages {
        public const String p_welcome = "Welcome Client";
        public const String p_readyToRecieve = "Ready to recieve data";
        public const String p_noSessionActive = "No current Session Active";

        public const String d_readyToRecieve = "Ready to receive command";
        public const String d_commandInvalid = "This command is not valid.";

        public const String d_enterLogin = "Enter Login Data";
        public const String d_incorrectLogin = "Incorrect Login";
        public const String d_correctLogin = "Login Successful";

        public const String d_retrieveData = "Retrieve Data";
        public const String d_subscribe = "Subscribe";
        public const String d_unsubscribe = "Unsubscribe";
        public const String d_sendData = "Send Data";
        public const String d_startSession = "Start Session";
        public const String d_endSession = "End Session";
        public const String d_retrieveDataResponse = "Which patient and date should data be retrieved from?";
        public const String d_subscribeResponse = "Which patient should be subscribed to?";
        public const String d_unsubscribeResponse = "Which patient should be unsubscribed from?";
        public const String d_sendDataResponse = "What data should be sent?";
        public const String d_startSessionResponse = "Which Patient should a session start?";
        public const String d_endSessionResponse = "Which Patient should a session End?";

        public const String d_personAlreadySubscribed = "This person is already subscribed to";
        public const String d_personNotSubscribed = "This person is not subscribed to";

        public const String a_patientNotExist = "This patient does not exist";
        public const String a_notJson = "This message was not a Json String";
        public const String a_goodbye = "Goodbye";
        public const String a_quit = "Quit Communication";
    }
}
