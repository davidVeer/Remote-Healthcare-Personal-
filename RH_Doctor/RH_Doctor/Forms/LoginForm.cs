using RH_Doctor.Connectivity;

namespace RH_Doctor.Forms {
    internal partial class LoginForm : UserControl {
        public readonly Form mainForm;
        public readonly ServerConnection serverConnection;
        
        public LoginForm(Form mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;
            serverConnection = new ServerConnection();
        }

        private void LoginButton_Click(object sender, EventArgs e) {

        }
    }
}
