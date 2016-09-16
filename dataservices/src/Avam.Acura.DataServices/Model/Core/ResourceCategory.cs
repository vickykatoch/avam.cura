using System;

namespace Avam.Acura.DataServices.Domain.Core
{
    public class ResourceCategory : AuditableBusinessEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ResourceCategory Parent {get;set;}
        public bool IsActive { get; set; }        
    }
}