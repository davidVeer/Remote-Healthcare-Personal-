using RH_Doctor.Connectivity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_Doctor.Forms {
    internal partial class AnaliticsForm : UserControl {
        public readonly Form mainForm;
        public readonly ServerConnection serverConnection;
        
        public AnaliticsForm(Form mainForm, ServerConnection serverConnection) {
            InitializeComponent();
            this.mainForm = mainForm;
            this.serverConnection = serverConnection;
        }
    }
}
