namespace PassKey.Login.MongoDb.Blazor.Server.UI.Data
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClockIn { get; set; }
        public string ClockOut { get; set; }
        public double TotalHours { get; set; }
        // Other properties...
    }
}

