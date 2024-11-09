using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Doctor.ActiveData {
    internal class Patient {
        private String name;
        public DataReading MostRecentReading { get; set; }
        public DataSet CurrentDataSet { get; set; }
        public DataSet LastRequestedDataSet { get; set; }

        public Patient(string name) {
            this.name = name;
        }
    }
}
