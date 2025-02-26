﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain.Command
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DataCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
