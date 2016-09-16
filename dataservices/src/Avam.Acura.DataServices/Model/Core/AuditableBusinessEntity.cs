using System;

namespace Avam.Acura.DataServices.Domain.Core
{
    public class AuditableBusinessEntity : BusinessEntity, IAuditable
    {
        public string CreatedBy {get;set;}
        public DateTime CreatedOn{get;set;}
        public string LastModifiedBy{get;set;}
        public DateTime LastModifiedOn{get;set;}
    }
}