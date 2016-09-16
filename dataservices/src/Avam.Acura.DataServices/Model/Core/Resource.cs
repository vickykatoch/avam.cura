using System;

namespace Avam.Acura.DataServices.Domain.Core
{
    public class Resource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ResourceType Type { get; set; }
        public Resource Parent {get;set;}
    }
}