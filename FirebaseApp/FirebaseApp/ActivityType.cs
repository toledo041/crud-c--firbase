using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseApp
{

    [FirestoreData]
    public class ActivityType
    {
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string activityName { get; set; }
        [FirestoreProperty]
        public string status { get; set; }
        
    }
}
