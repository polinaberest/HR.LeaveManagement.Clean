﻿using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Features.LeaveRequest.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommandValidator : AbstractValidator<CreateLeaveRequestCommand>
    {
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public CreateLeaveRequestCommandValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            Include(new BaseLeaveRequestValidator(leaveTypeRepository));
        }
    }
}
