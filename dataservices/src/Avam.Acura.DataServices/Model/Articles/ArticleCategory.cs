using Avam.Acura.DataServices.Domain.Core;

namespace Avam.Acura.DataServices.Domain.Articles
{
    public class ArticleCategory : BusinessEntity{
        public Article Article {get;set;}
        public ResourceCategory Category {get;set;}
    }
}