namespace Avam.Acura.DataServices.Domain.Core
{
    public class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail {get;set;}
        public UserAuthenticationType AuthType {get;set;}
    }
}