﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveType
{
    public class GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
    {
    }
}
