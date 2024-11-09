using RH_Doctor.Forms;

namespace RH_Doctor {
    internal static class Startup {

        [STAThread]
        static void Main(String[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartupGui();
        }

        private static void StartupGui() {
            Form mainForm = new Form();
            LoginForm initialWindow = new LoginForm(mainForm);

            initialWindow.Dock = DockStyle.Fill;

            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.Controls.Add(initialWindow);
            mainForm.Text = "DoctorApplication";
            Application.Run(mainForm);
        }

    }
}