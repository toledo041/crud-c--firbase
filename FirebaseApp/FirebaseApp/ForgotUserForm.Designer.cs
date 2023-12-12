namespace FirebaseApp
{
    partial class ForgotUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Password = new Label();
            label3 = new Label();
            userTxt = new TextBox();
            passTxt = new TextBox();
            pass2Txt = new TextBox();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(11, 65);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 115);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirm your password";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(12, 31);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(248, 23);
            userTxt.TabIndex = 3;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(11, 83);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(248, 23);
            passTxt.TabIndex = 4;
            // 
            // pass2Txt
            // 
            pass2Txt.Location = new Point(11, 133);
            pass2Txt.Name = "pass2Txt";
            pass2Txt.Size = new Size(248, 23);
            pass2Txt.TabIndex = 5;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(90, 165);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // ForgotUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 200);
            Controls.Add(updateBtn);
            Controls.Add(pass2Txt);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(label1);
            Name = "ForgotUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotUserForm";
            FormClosing += ForgotUserForm_FormClosing;
            Load += ForgotUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Password;
        private Label label3;
        private TextBox userTxt;
        private TextBox passTxt;
        private TextBox pass2Txt;
        private Button updateBtn;
    }
}