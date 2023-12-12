using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseApp
{
    [FirestoreData]
    public class ComplementaryActivity
    {
        [FirestoreProperty]
        public string Document { get; set; }
        [FirestoreProperty]
        public string activityName { get; set; }
        [FirestoreProperty]
        public string idStudent { get; set; }

        [FirestoreProperty]
        public string idActivityType { get; set; }
        [FirestoreProperty]
        public Timestamp dateCreate { get; set; }
        [FirestoreProperty]
        public string idUserCreate { get; set; }

        [FirestoreProperty]
        public Timestamp dateModified { get; set; }
        [FirestoreProperty]
        public string idUserModified { get; set; }
        [FirestoreProperty]
        public String status { get; set; }
      
    }
}
