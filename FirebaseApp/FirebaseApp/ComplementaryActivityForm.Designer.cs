namespace FirebaseApp
{
    partial class ComplementaryActivityForm
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
            activityNameTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            StudentComboBox = new ComboBox();
            ActivityTypeComboBox = new ComboBox();
            actionBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Activity name";
            // 
            // activityNameTxt
            // 
            activityNameTxt.Location = new Point(8, 30);
            activityNameTxt.Name = "activityNameTxt";
            activityNameTxt.Size = new Size(341, 23);
            activityNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 121);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Activity type";
            // 
            // StudentComboBox
            // 
            StudentComboBox.FormattingEnabled = true;
            StudentComboBox.Location = new Point(8, 84);
            StudentComboBox.Name = "StudentComboBox";
            StudentComboBox.Size = new Size(341, 23);
            StudentComboBox.TabIndex = 4;
            // 
            // ActivityTypeComboBox
            // 
            ActivityTypeComboBox.FormattingEnabled = true;
            ActivityTypeComboBox.Location = new Point(8, 139);
            ActivityTypeComboBox.Name = "ActivityTypeComboBox";
            ActivityTypeComboBox.Size = new Size(341, 23);
            ActivityTypeComboBox.TabIndex = 5;
            // 
            // actionBtn
            // 
            actionBtn.Location = new Point(62, 180);
            actionBtn.Name = "actionBtn";
            actionBtn.Size = new Size(75, 23);
            actionBtn.TabIndex = 6;
            actionBtn.Text = "Save";
            actionBtn.UseVisualStyleBackColor = true;
            actionBtn.Click += actionBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(171, 180);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Visible = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ComplementaryActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 223);
            Controls.Add(deleteBtn);
            Controls.Add(actionBtn);
            Controls.Add(ActivityTypeComboBox);
            Controls.Add(StudentComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(activityNameTxt);
            Controls.Add(label1);
            Name = "ComplementaryActivityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComplementaryActivityForm";
            FormClosing += ComplementaryActivityForm_FormClosing;
            Load += ComplementaryActivityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox activityNameTxt;
        private Label label2;
        private Label label3;
        private ComboBox StudentComboBox;
        private ComboBox ActivityTypeComboBox;
        private Button actionBtn;
        private Button deleteBtn;
    }
}