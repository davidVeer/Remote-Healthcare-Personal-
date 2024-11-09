namespace RH_Doctor.Forms {
    partial class AnaliticsForm {
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
            listView1 = new ListView();
            listView2 = new ListView();
            Resistances = new Label();
            DoctorMessages = new Label();
            OverviewButton = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(49, 333);
            listView1.Name = "listView1";
            listView1.Size = new Size(347, 100);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(402, 333);
            listView2.Name = "listView2";
            listView2.Size = new Size(356, 100);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Resistances
            // 
            Resistances.AutoSize = true;
            Resistances.Location = new Point(402, 315);
            Resistances.Name = "Resistances";
            Resistances.Size = new Size(67, 15);
            Resistances.TabIndex = 2;
            Resistances.Text = "Resistances";
            // 
            // DoctorMessages
            // 
            DoctorMessages.AutoSize = true;
            DoctorMessages.Location = new Point(49, 315);
            DoctorMessages.Name = "DoctorMessages";
            DoctorMessages.Size = new Size(128, 15);
            DoctorMessages.TabIndex = 3;
            DoctorMessages.Text = "Messages From Doctor";
            // 
            // OverviewButton
            // 
            OverviewButton.Location = new Point(49, 19);
            OverviewButton.Name = "OverviewButton";
            OverviewButton.Size = new Size(128, 40);
            OverviewButton.TabIndex = 4;
            OverviewButton.Text = "Back to Overview";
            OverviewButton.UseVisualStyleBackColor = true;
            // 
            // AnaliticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OverviewButton);
            Controls.Add(DoctorMessages);
            Controls.Add(Resistances);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "AnaliticsForm";
            Size = new Size(802, 465);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private Label Resistances;
        private Label DoctorMessages;
        private Button OverviewButton;
    }
}
