using RH_Doctor.Connectivity;

using System.Windows.Forms;

namespace RH_Doctor.Forms {
    internal partial class OverView : UserControl {
        public readonly Form mainForm;
        public readonly ServerConnection serverConnection;

        public OverView(Form mainForm, ServerConnection serverConnection) {
            InitializeComponent();
            this.mainForm = mainForm;
            this.serverConnection = serverConnection;
        }
    }
}
