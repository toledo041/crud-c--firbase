namespace FirebaseApp
{
    partial class RegisterUserForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userTxt = new TextBox();
            emailTxt = new TextBox();
            passTxt = new TextBox();
            pass2Txt = new TextBox();
            registerBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 110);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm your password";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(10, 26);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(280, 23);
            userTxt.TabIndex = 4;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(10, 77);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(280, 23);
            emailTxt.TabIndex = 5;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(10, 128);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(280, 23);
            passTxt.TabIndex = 6;
            // 
            // pass2Txt
            // 
            pass2Txt.Location = new Point(10, 177);
            pass2Txt.Name = "pass2Txt";
            pass2Txt.Size = new Size(280, 23);
            pass2Txt.TabIndex = 7;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(102, 216);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 8;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // RegisterUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 249);
            Controls.Add(registerBtn);
            Controls.Add(pass2Txt);
            Controls.Add(passTxt);
            Controls.Add(emailTxt);
            Controls.Add(userTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register user";
            FormClosing += RegisterUserForm_FormClosing;
            Load += RegisterUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox userTxt;
        private TextBox emailTxt;
        private TextBox passTxt;
        private TextBox pass2Txt;
        private Button registerBtn;
    }
}