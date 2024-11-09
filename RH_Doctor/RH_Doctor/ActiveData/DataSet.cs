using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Doctor.ActiveData {
    internal class DataSet {
        public List<DataReading> dataReadings {  get; }
        public List<String> messagesFromDoctor { get; }

        public DataSet() {
            this.dataReadings = new List<DataReading>();
            this.messagesFromDoctor = new List<string>();
        }
    }
}
