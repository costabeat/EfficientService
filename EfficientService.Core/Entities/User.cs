using System;

namespace EfficientService.Core.Entities
{
    public class User
    {
        public Guid PKID { get; internal set; }
        public string FullName { get; set; }
        public int? DepartmentID { get; set; }
        public string Post { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Jabber { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
