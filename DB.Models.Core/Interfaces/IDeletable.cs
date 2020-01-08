using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Models.Core.Interfaces
{
    public interface IDeletable
    {
        bool IsActive { get; set; }
    }
}
