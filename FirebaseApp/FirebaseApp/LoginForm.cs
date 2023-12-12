using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirebaseApp
{
    public partial class LoginForm : Form
    {
        FirestoreDb database;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        async void login()
        {
            Query query = database.Collection("User").WhereEqualTo("status", "1")
                                                     .WhereEqualTo("name", userTxt.Text)
                                                     .WhereEqualTo("password", passTxt.Text).Limit(1);
            QuerySnapshot snap = await query.GetSnapshotAsync();

            if (snap.Count > 0)
            {
                User user = snap.First().ConvertTo<User>();
                user.Document = snap.First().Id;

                Form1 form1 = new Form1();
                form1.user = user;
                form1.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("User not found!");
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"vinculation-37b81-firebase-adminsdk-eatik-db78ff6ca8.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("vinculation-37b81");
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterUserForm form1 = new RegisterUserForm();
            form1.Show();

            this.Hide();
        }

        private void forgotLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotUserForm form1 = new ForgotUserForm();
            form1.Show();

            this.Hide();
        }
    }
}
