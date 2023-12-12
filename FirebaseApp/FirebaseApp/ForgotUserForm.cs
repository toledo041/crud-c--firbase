using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FirebaseApp
{
    public partial class ForgotUserForm : Form
    {
        FirestoreDb database;
        public ForgotUserForm()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            existUserEmail();

            // Datos para la inserción            
            

          
        }

        private void ForgotUserForm_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"vinculation-37b81-firebase-adminsdk-eatik-db78ff6ca8.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("vinculation-37b81");
        }

        private void ForgotUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();

            this.Hide();
        }

        async void existUserEmail()
        {


            string name = userTxt.Text;
            string pass = passTxt.Text;
            string pass2 = pass2Txt.Text;
            User user = null;


            Query query = database.Collection("User").WhereEqualTo("name", name);
            QuerySnapshot snap = await query.GetSnapshotAsync();

            if (snap.Count > 0)
            {
                user = snap.First().ConvertTo<User>();
                user.Document = snap.First().Id;
            }

            

            if (pass == pass2)
            {
                if (user != null)
                {

                    DocumentReference docRef = database.Collection("User").Document(user.Document);
                    Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        {"name",name},
                        {"password",pass}


                    };

                    DocumentSnapshot snapDoc = await docRef.GetSnapshotAsync();
                    if (snapDoc.Exists)
                    {
                        await docRef.UpdateAsync(data);
                    }
                    MessageBox.Show("Data updated successfully!");


                    LoginForm form1 = new LoginForm();
                    form1.Show();
                    this.Hide();

                }
                else {
                    MessageBox.Show("User not exist.", "Info");
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match.", "Info");
            }

        }
    }
}
