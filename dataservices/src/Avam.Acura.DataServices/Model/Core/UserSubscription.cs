namespace Avam.Acura.DataServices.Domain.Core
{
    public class UserSubscription : AuditableBusinessEntity
    {
        public ResourceCategory Category { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; }        
    }
}