using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Doctor.ActiveData {
    internal class DataReading {
        public int BicycleSpeed { get; }
        public int HeartRate { get; }
        public DateTime RecordedDateTime { get; }

        public DataReading(int bicycleSpeed, int heartRate, DateTime recordedDateTime) {
            BicycleSpeed = bicycleSpeed;
            HeartRate = heartRate;
            RecordedDateTime = recordedDateTime;
        }
    }
}
