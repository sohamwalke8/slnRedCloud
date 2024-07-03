namespace RedCloud.Services
{
    public class AuditLog
    {
        public DateTime DateAndTime { get; set; }
        public string UserEmail { get; set; }
        public string UserRole { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
    }

}
