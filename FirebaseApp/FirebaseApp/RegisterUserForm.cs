using Google.Cloud.Firestore;

using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RegisterUserForm : Form
    {
        FirestoreDb database;
        private Boolean exist = false;
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            existUserEmail();

            // Datos para la inserción            
            string name = userTxt.Text;
            string email = emailTxt.Text;
            string pass = passTxt.Text;
            string pass2 = pass2Txt.Text;

            if (pass == pass2)
            {
                if (exist)
                {
                    MessageBox.Show("That username or email is already registered.", "Info");
                }
                else
                { //no existe

                    CollectionReference coll = database.Collection("User");
                    Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        {"name",name},
                        {"email", email},
                        {"password",pass},                    
                        {"status","1"}

                    };
                    coll.AddAsync(data);
                    MessageBox.Show("Successful insertion.", "Info");

                    LoginForm form1 = new LoginForm();
                    form1.Show();
                    this.Hide();
                    
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match.", "Info");
            }
        }
        async void existUserEmail()
        {

            string textoBuscado = userTxt.Text;
            string pass = passTxt.Text;
            

            Query query = database.Collection("User").WhereEqualTo("email", emailTxt.Text)
                                                     .WhereEqualTo("name", userTxt.Text);
            QuerySnapshot snap = await query.GetSnapshotAsync();

            if (snap.Count > 0)
            {
                exist = true;
            }
            
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"vinculation-37b81-firebase-adminsdk-eatik-db78ff6ca8.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("vinculation-37b81");
        }

        private void RegisterUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form1 = new LoginForm();            
            form1.Show();

            this.Hide();
        }
    }
}
