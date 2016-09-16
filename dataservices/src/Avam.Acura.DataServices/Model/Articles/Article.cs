using System;
using Avam.Acura.DataServices.Domain.Core;

namespace Avam.Acura.DataServices.Domain.Articles
{
    public class Article : AuditableBusinessEntity{
        public string Title {get;set;}
        public string Description {get;set;}
        public string Author {get;set;}
        public ResourceCategory Category {get;set;}
        public DateTime PublishDate {get;set;}
        public string ContentPath {get;set;}
        public bool IsProcessed {get;set;}
        public bool Complexity {get;set;}
        public bool IsObsolete {get;set;}
    }
}