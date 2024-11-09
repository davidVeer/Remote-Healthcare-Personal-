namespace RH_Doctor.Forms {
    partial class OverView {

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Message = new Label();
            Resistance = new Label();
            monthCalendar1 = new MonthCalendar();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SendMessage = new Button();
            EndSession = new Button();
            Subscrube = new Button();
            Unsubscribe = new Button();
            StartSession = new Button();
            AnaliticsButton = new Button();
            DateSelection = new Button();
            dataGridView1 = new DataGridView();
            PatientName = new DataGridViewTextBoxColumn();
            Speed = new DataGridViewTextBoxColumn();
            HeartRate = new DataGridViewTextBoxColumn();
            TimeUpdated = new DataGridViewTextBoxColumn();
            Selection = new DataGridViewCheckBoxColumn();
            MessageEmergency = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(263, 339);
            Message.Name = "Message";
            Message.Size = new Size(53, 15);
            Message.TabIndex = 25;
            Message.Text = "Message";
            // 
            // Resistance
            // 
            Resistance.AutoSize = true;
            Resistance.Location = new Point(548, 339);
            Resistance.Name = "Resistance";
            Resistance.Size = new Size(62, 15);
            Resistance.TabIndex = 24;
            Resistance.Text = "Resistance";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(263, 511);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(548, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 364);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 21;
            // 
            // SendMessage
            // 
            SendMessage.Location = new Point(263, 304);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new Size(103, 23);
            SendMessage.TabIndex = 20;
            SendMessage.Text = "Send Message";
            SendMessage.UseVisualStyleBackColor = true;
            // 
            // EndSession
            // 
            EndSession.Location = new Point(106, 335);
            EndSession.Name = "EndSession";
            EndSession.Size = new Size(84, 23);
            EndSession.TabIndex = 19;
            EndSession.Text = "End Session";
            EndSession.UseVisualStyleBackColor = true;
            // 
            // Subscrube
            // 
            Subscrube.Location = new Point(106, 363);
            Subscrube.Name = "Subscrube";
            Subscrube.Size = new Size(75, 23);
            Subscrube.TabIndex = 18;
            Subscrube.Text = "Subscribe";
            Subscrube.UseVisualStyleBackColor = true;
            // 
            // Unsubscribe
            // 
            Unsubscribe.Location = new Point(106, 393);
            Unsubscribe.Name = "Unsubscribe";
            Unsubscribe.Size = new Size(84, 23);
            Unsubscribe.TabIndex = 17;
            Unsubscribe.Text = "Unsubscribe";
            Unsubscribe.UseVisualStyleBackColor = true;
            // 
            // StartSession
            // 
            StartSession.Location = new Point(106, 306);
            StartSession.Name = "StartSession";
            StartSession.Size = new Size(84, 23);
            StartSession.TabIndex = 16;
            StartSession.Text = "Start Session";
            StartSession.UseVisualStyleBackColor = true;
            // 
            // AnaliticsButton
            // 
            AnaliticsButton.Location = new Point(106, 476);
            AnaliticsButton.Name = "AnaliticsButton";
            AnaliticsButton.Size = new Size(96, 23);
            AnaliticsButton.TabIndex = 15;
            AnaliticsButton.Text = "View Analitics";
            AnaliticsButton.UseVisualStyleBackColor = true;
            // 
            // DateSelection
            // 
            DateSelection.Location = new Point(263, 476);
            DateSelection.Name = "DateSelection";
            DateSelection.Size = new Size(103, 23);
            DateSelection.TabIndex = 14;
            DateSelection.Text = "Fetch session";
            DateSelection.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PatientName, Speed, HeartRate, TimeUpdated, Selection });
            dataGridView1.Location = new Point(106, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 238);
            dataGridView1.TabIndex = 13;
            // 
            // PatientName
            // 
            PatientName.HeaderText = "Name";
            PatientName.Name = "PatientName";
            // 
            // Speed
            // 
            Speed.HeaderText = "Speed";
            Speed.Name = "Speed";
            // 
            // HeartRate
            // 
            HeartRate.HeaderText = "Heart Rate";
            HeartRate.Name = "HeartRate";
            // 
            // TimeUpdated
            // 
            TimeUpdated.HeaderText = "Time Updated";
            TimeUpdated.Name = "TimeUpdated";
            // 
            // Selection
            // 
            Selection.HeaderText = "Select";
            Selection.Name = "Selection";
            // 
            // MessageEmergency
            // 
            MessageEmergency.Location = new Point(372, 304);
            MessageEmergency.Name = "MessageEmergency";
            MessageEmergency.Size = new Size(111, 23);
            MessageEmergency.TabIndex = 27;
            MessageEmergency.Text = "Emergency Stop";
            MessageEmergency.UseVisualStyleBackColor = true;
            // 
            // OverView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MessageEmergency);
            Controls.Add(Message);
            Controls.Add(Resistance);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SendMessage);
            Controls.Add(EndSession);
            Controls.Add(Subscrube);
            Controls.Add(Unsubscribe);
            Controls.Add(StartSession);
            Controls.Add(AnaliticsButton);
            Controls.Add(DateSelection);
            Controls.Add(dataGridView1);
            Name = "OverView";
            Size = new Size(763, 750);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Message;
        private Label Resistance;
        private MonthCalendar monthCalendar1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button SendMessage;
        private Button EndSession;
        private Button Subscrube;
        private Button Unsubscribe;
        private Button StartSession;
        private Button AnaliticsButton;
        private Button DateSelection;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn Speed;
        private DataGridViewTextBoxColumn HeartRate;
        private DataGridViewTextBoxColumn TimeUpdated;
        private DataGridViewCheckBoxColumn Selection;
        private Button MessageEmergency;
    }
}
