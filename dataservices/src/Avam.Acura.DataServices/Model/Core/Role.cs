using System;

namespace Avam.Acura.DataServices.Domain.Core
{
    public class Role
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
    }
}