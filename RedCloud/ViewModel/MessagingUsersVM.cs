namespace RedCloud.ViewModel
{
    public class MessagingUsersVM
    {
        public int MessagingUserId { get; set; }
        public string MessagingUserFirstName { get; set; }
        public string MessagingUserLastName { get; set; }
        public string MessagingUserEmail { get; set; }
        public string AssignedNumber { get; set; }
        public string? MessagingUserType { get; set; }

        public bool IsActive { get; set; }
    }
}
