using Avam.Acura.DataServices.Domain.Core;

namespace Avam.Acura.DataServices.Domain.Articles
{
    public class UserBagItem : AuditableBusinessEntity{
        public Article Article {get;set;}
        public User User {get;set;}
    }
}