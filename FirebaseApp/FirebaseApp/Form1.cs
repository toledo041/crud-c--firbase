using Google.Cloud.Firestore;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirebaseApp
{
    public partial class Form1 : Form
    {
        FirestoreDb database;
        private DataTable tabla;
        public User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            String path = AppDomain.CurrentDomain.BaseDirectory + @"vinculation-37b81-firebase-adminsdk-eatik-db78ff6ca8.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("vinculation-37b81");
            ConfigurarDataGridView();
            CargarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //addElemenCustomtId();
            //addElementIdGenerated();
            //getAllStudens();

            ComplementaryActivityForm complementaryActivityForm = new ComplementaryActivityForm();
            complementaryActivityForm.User = user;
            complementaryActivityForm.Show();
            this.Hide();

        }

        private void ConfigurarDataGridView()
        {
            tabla = new DataTable();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = tabla;
        }

        async void CargarDatos()
        {
            Query query = database.Collection("ComplementaryActivity").WhereEqualTo("status", "1");
            QuerySnapshot snap = await query.GetSnapshotAsync();

            List<ComplementaryActivity> studentsList = new List<ComplementaryActivity>();

            foreach (DocumentSnapshot docSnap in snap)
            {
                ComplementaryActivity student = docSnap.ConvertTo<ComplementaryActivity>();
                student.Document = docSnap.Id;
                studentsList.Add(student);
            }

            // Suponiendo que tienes un DataGridView llamado dataGridView1
            dataGridView1.DataSource = studentsList;

            // Opcional: Puedes personalizar las columnas del DataGridView
            // por ejemplo, si quieres mostrar solo ciertas propiedades
            dataGridView1.Columns["Document"].HeaderText = "Id";//.Visible = false; // Oculta la columna Id
            dataGridView1.Columns["activityName"].HeaderText = "activityName";
            dataGridView1.Columns["idStudent"].HeaderText = "Student";
            dataGridView1.Columns["idActivityType"].HeaderText = "ActivityType";
            dataGridView1.Columns["dateCreate"].Visible = false;
            dataGridView1.Columns["idUserCreate"].Visible = false;
            dataGridView1.Columns["dateModified"].Visible = false;
            dataGridView1.Columns["idUserModified"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;


        }


        private void addElementIdGenerated()
        {
            //Crea un elemento en la coleccion Student
            CollectionReference coll = database.Collection("Student");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name","Nallely Toledo" },
                {"enrollment","info" },
                {"birthdate","04/11/1997" }
            };
            coll.AddAsync(data);
            MessageBox.Show("Data added successfully!");
        }

        private void addElemenCustomtId()
        {
            //Crea un elemento en la coleccion Student
            DocumentReference doc = database.Collection("Student").Document("MyDoc");
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"name","Nallely Toledo" },
                {"enrollment","info" },
                {"birthdate","04/11/1997" }
            };
            doc.SetAsync(data);
            MessageBox.Show("Data added successfully!");
        }

        async void getDataStudentByDocument()
        {
            DocumentReference documentReference = database.Collection("Student").Document("MyDoc");
            DocumentSnapshot snap = await documentReference.GetSnapshotAsync();

            string result = "";
            if (snap.Exists)
            {
                Dictionary<string, object> student = snap.ToDictionary();
                foreach (var item in student)
                {
                    result += string.Format("{0},{1}\n", item.Key, item.Value);
                }
            }
            MessageBox.Show(result);
        }

        async void getStudentByDocument()
        {
            DocumentReference documentReference = database.Collection("Student").Document("MyDoc");
            DocumentSnapshot snap = await documentReference.GetSnapshotAsync();

            string result = "";
            if (snap.Exists)
            {
                Student student = snap.ConvertTo<Student>();
                //student.name;
                //..
            }
            MessageBox.Show(result);
        }

        async void getAllStudens()
        {
            Query query = database.Collection("Student"); //.WhereEqualTo("propiedad")
            QuerySnapshot snap = await query.GetSnapshotAsync();

            string result = "";
            foreach (DocumentSnapshot docSnap in snap)
            {
                Student student = docSnap.ConvertTo<Student>();
                result += string.Format("Name {0}, enrollment {1}, birtdate {2} \n", student.name, student.enrollment, student.birthdate);
            }


            MessageBox.Show(result);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la información de la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Datos para la inserción            
                // Obtener los valores de las celdas
                string id = filaSeleccionada.Cells["Document"].Value.ToString();
                string activityName = filaSeleccionada.Cells["activityName"].Value.ToString();
                string idStudent = filaSeleccionada.Cells["idStudent"].Value.ToString();
                string idActivityType = filaSeleccionada.Cells["idActivityType"].Value.ToString();


                ComplementaryActivity activity = new ComplementaryActivity();
                activity.Document = id;
                activity.activityName = activityName;
                activity.idStudent = idStudent;
                activity.idActivityType = idActivityType;

                ComplementaryActivityForm activityForm = new ComplementaryActivityForm();
                activityForm.User = user;
                activityForm.action = "update";
                activityForm.setDatosForm(activity);
                activityForm.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm form1 = new LoginForm();            
            form1.Show();

            this.Hide();
        }
    }
}