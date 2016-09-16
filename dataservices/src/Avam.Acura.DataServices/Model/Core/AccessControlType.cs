using System;

namespace Avam.Acura.DataServices.Domain.Core
{
    [Flags]
    public enum AccessControlType {
        Create=1,
        Read=2,
        Update=4,
        Delete=8,
    }
}