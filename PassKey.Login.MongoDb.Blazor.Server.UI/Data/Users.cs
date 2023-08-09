using MongoDB.Bson.Serialization.Attributes;

namespace PassKey.Login.MongoDb.Blazor.Server.UI.Data
{
 
    public class Users
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string SystemDetail { get; set; }

        public string MachineName2 { get; set; }

        public string OperatingSystem { get; set; }

        public string System { get; set; }

        public string UniqueIdentifier { get; set; }

        public string IPAddress { get; set; }

        public string CompanyName { get; set; }


        public string CompanyId { get; set; }

        public string GroupID { get; set; }

        public string ClockIn { get; set; }
        public string ClockOut { get; set; }
        public double TotalHours { get; set; }


    }
}