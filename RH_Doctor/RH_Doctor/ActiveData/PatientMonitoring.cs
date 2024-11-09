using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RH_Doctor.ActiveData {
    internal class PatientMonitoring {
        public readonly Dictionary<String, Patient> patients;

        public PatientMonitoring() {
            patients = new Dictionary<string, Patient>();
        }

        public void CheckAndAddPatient(String patientName) {
            throw new NotImplementedException();
        }

        public bool PatientExists(String patientName) {
            throw new NotImplementedException();
        }
    }
}
