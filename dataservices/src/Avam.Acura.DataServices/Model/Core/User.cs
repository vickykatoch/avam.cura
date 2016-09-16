namespace Avam.Acura.DataServices.Domain.Core
{
    public class User : AuditableBusinessEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail {get;set;}
        public UserAuthenticationType AuthType {get;set;}
        public bool IsAdmin {get;set;}
    }
}