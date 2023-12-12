namespace FirebaseApp
{
    partial class LoginForm
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
            userTxt = new TextBox();
            passTxt = new TextBox();
            button1 = new Button();
            registerBtn = new Button();
            forgotLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 65);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userTxt
            // 
            userTxt.Location = new Point(16, 27);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(229, 23);
            userTxt.TabIndex = 2;
            // 
            // passTxt
            // 
            passTxt.Location = new Point(16, 83);
            passTxt.Name = "passTxt";
            passTxt.PasswordChar = '*';
            passTxt.Size = new Size(229, 23);
            passTxt.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(45, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(139, 123);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(75, 23);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // forgotLink
            // 
            forgotLink.AutoSize = true;
            forgotLink.Location = new Point(60, 165);
            forgotLink.Name = "forgotLink";
            forgotLink.Size = new Size(122, 15);
            forgotLink.TabIndex = 6;
            forgotLink.TabStop = true;
            forgotLink.Text = "Forgot your password";
            forgotLink.LinkClicked += forgotLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 233);
            Controls.Add(forgotLink);
            Controls.Add(registerBtn);
            Controls.Add(button1);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userTxt;
        private TextBox passTxt;
        private Button button1;
        private Button registerBtn;
        private LinkLabel forgotLink;
    }
}