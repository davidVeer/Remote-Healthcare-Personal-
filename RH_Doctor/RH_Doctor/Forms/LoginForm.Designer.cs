namespace RH_Doctor.Forms {
    partial class LoginForm {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IDBox = new TextBox();
            NameBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 75);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "ID number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 153);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Doctor name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 239);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(283, 93);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(197, 23);
            IDBox.TabIndex = 3;
            IDBox.Text = "Enter ID number";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(283, 171);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(197, 23);
            NameBox.TabIndex = 4;
            NameBox.Text = "Enter Name";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(283, 257);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(197, 23);
            PasswordBox.TabIndex = 5;
            PasswordBox.Text = "Enter Password";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.Control;
            LoginButton.Location = new Point(283, 338);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(197, 44);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(NameBox);
            Controls.Add(IDBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Size = new Size(762, 438);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IDBox;
        private TextBox NameBox;
        private TextBox PasswordBox;
        private Button LoginButton;
    }
}
