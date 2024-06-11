namespace RedCloud.ViewModel
{
    public class OrganizationUserVM
    {
        public int OrganizationUserId { get; set; }

        public string OrganizationUserFirstName { get; set; }


        public string OrganizationUserLastName { get; set; }

        public string OrganizationUserEmail { get; set; }

        public string? OrganizationUserPassword { get; set; }

        public bool IsActive { get; set; } = true;

        public int? OrganizationAdminId { get; set; }
    }
}
