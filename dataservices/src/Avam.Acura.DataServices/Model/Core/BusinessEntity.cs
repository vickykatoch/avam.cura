using System;

namespace Avam.Acura.DataServices.Domain.Core
{
    public class BusinessEntity{
        public int Id{get;set;}
        public bool IsNew { get; set; }
        public bool IsDirty { get; set; }
    }
}