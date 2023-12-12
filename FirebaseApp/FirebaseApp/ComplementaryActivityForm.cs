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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirebaseApp
{
    public partial class ComplementaryActivityForm : Form
    {
        public string action = "register";
        public ComplementaryActivity element;
        public User User;
        private List<Student> studentsList = new List<Student>();
        List<ActivityType> activityTypeList = new List<ActivityType>();

        FirestoreDb database;

        public ComplementaryActivityForm()
        {
            InitializeComponent();
        }

        private void ComplementaryActivityForm_Load(object sender, EventArgs e)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"vinculation-37b81-firebase-adminsdk-eatik-db78ff6ca8.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("vinculation-37b81");

            PopulateStudentComboBox();
            PopulateActivityTypeComboBox();

        }

        private void ComplementaryActivityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.user = User;
            form1.Show();
            this.Hide();
        }

        async void PopulateStudentComboBox()
        {
            Query query = database.Collection("Student");
            QuerySnapshot snap = await query.GetSnapshotAsync();

            //List<Student> 
            studentsList = new List<Student>();

            foreach (DocumentSnapshot docSnap in snap)
            {
                Student student = docSnap.ConvertTo<Student>();
                student.Id = docSnap.Id;
                studentsList.Add(student);
            }

            // Suponiendo que tienes un ComboBox llamado comboBox1
            StudentComboBox.DisplayMember = "Name"; // Muestra la propiedad Name en el ComboBox
            StudentComboBox.ValueMember = "Id"; // Usa la propiedad Id como valor del ComboBox
            StudentComboBox.DataSource = studentsList;
        }

        async void PopulateActivityTypeComboBox()
        {
            Query query = database.Collection("ActivityType");
            QuerySnapshot snap = await query.GetSnapshotAsync();

            //List<ActivityType> 
            activityTypeList = new List<ActivityType>();

            foreach (DocumentSnapshot docSnap in snap)
            {
                ActivityType activityType = docSnap.ConvertTo<ActivityType>();
                activityType.Id = docSnap.Id;
                activityTypeList.Add(activityType);
            }

            // Suponiendo que tienes un ComboBox llamado comboBox1
            ActivityTypeComboBox.DisplayMember = "activityName"; // Muestra la propiedad Name en el ComboBox
            ActivityTypeComboBox.ValueMember = "Id"; // Usa la propiedad Id como valor del ComboBox
            ActivityTypeComboBox.DataSource = activityTypeList;
        }

        private async void actionBtn_Click(object sender, EventArgs e)
        {
            if (activityNameTxt.Text == "")
            {
                MessageBox.Show("You must capture all fields to continue.", "Info");
                return;
            }

            if (action == "register")
            {
                //Crea un elemento en la coleccion Student
                CollectionReference coll = database.Collection("ComplementaryActivity");
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"activityName",activityNameTxt.Text},
                    {"idStudent", studentsList[StudentComboBox.SelectedIndex].name},
                    {"idActivityType",activityTypeList[ActivityTypeComboBox.SelectedIndex].activityName},
                    {"dateCreate",new Timestamp()},
                    {"idUserCreate",User.Document},
                    {"idUserModified",""},
                    {"datemodified",null},
                    {"status","1"}

                };
                coll.AddAsync(data);
                MessageBox.Show("Data added successfully!");
                Form1 form1 = new Form1();
                form1.user = User;
                form1.Show();
                this.Hide();
            }
            else
            {

                DocumentReference docRef = database.Collection("ComplementaryActivity").Document(element.Document);
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"activityName",activityNameTxt.Text},
                    {"idStudent", studentsList[StudentComboBox.SelectedIndex].name},
                    {"idActivityType",activityTypeList[ActivityTypeComboBox.SelectedIndex].activityName},
                    {"idUserModified",User.Document},
                    {"datemodified",new Timestamp()}


                };

                DocumentSnapshot snapDoc = await docRef.GetSnapshotAsync();
                if (snapDoc.Exists)
                {
                    await docRef.UpdateAsync(data);
                }
                MessageBox.Show("Data updated successfully!");
                Form1 form1 = new Form1();
                form1.user = User;
                form1.Show();
                this.Hide();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿You want to delete this item?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // El usuario hizo clic en "Sí", realiza la acción correspondiente
                deleteDocument();
            }
            
        }

        async void deleteDocument()
        {
            DocumentReference docRef = database.Collection("ComplementaryActivity").Document(element.Document);
            Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {"status","0"}
                };

            DocumentSnapshot snapDoc = await docRef.GetSnapshotAsync();
            if (snapDoc.Exists)
            {
                await docRef.UpdateAsync(data);
            }
            MessageBox.Show("Data deleted successfully!");
            Form1 form1 = new Form1();
            form1.user = User;
            form1.Show();
            this.Hide();
        }

        public void setDatosForm(ComplementaryActivity modelo)
        {
            element = modelo;
            activityNameTxt.Text = modelo.activityName;

            actionBtn.Text = "Update";
            deleteBtn.Visible = true;


            Student seletedItem = new Student();

            foreach (Student elm in studentsList)
            {
                if (modelo.idStudent == elm.name)
                {
                    seletedItem = elm;
                    break;
                }

            }
            StudentComboBox.SelectedItem = seletedItem;

            ActivityType seletedAtItem = new ActivityType();

            foreach (ActivityType act in activityTypeList)
            {
                if (modelo.idActivityType == act.activityName)
                {
                    seletedAtItem = act;
                    break;
                }

            }
            ActivityTypeComboBox.SelectedItem = seletedAtItem;

        }
    }
}
