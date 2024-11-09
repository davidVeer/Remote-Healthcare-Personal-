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

        public static String RecieveMessage(NetworkStream recievingStream, String MessageToSend) {
            try {
                var stream = new StreamReader(recievingStream, Encoding.ASCII, true, 128);
                String line = stream.ReadLine();
                return line;
            } catch (IOException exception) {
                return "Connection With Host Was Lost";
            }
        }
    }
}
