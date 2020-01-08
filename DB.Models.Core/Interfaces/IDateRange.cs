﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Models.Core.Interfaces
{
    public interface IDateRange : IPopulateDates, IDeletable
    {
        int IDateRangeId { get; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }

        //TODO: this may belong in IDeleteable with IsActive,
        //but then many non-effDate tables would get it as well
        DateTime? DeactivatedDate { get; set; }
    }
}
