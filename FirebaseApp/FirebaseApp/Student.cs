using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseApp
{
    [FirestoreData]
    public class Student
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string name { get; set; }
        [FirestoreProperty]
        public string enrollment { get; set; }
        [FirestoreProperty]
        public string birthdate { get; set; }
    }
}
