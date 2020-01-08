using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Models.Core.Interfaces
{
    public interface IPopulateDates
    {
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        void PopulateDates();
    }
}
