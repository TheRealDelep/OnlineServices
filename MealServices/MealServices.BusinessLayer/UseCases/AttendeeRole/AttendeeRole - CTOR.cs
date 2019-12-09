﻿using OnlineServices.Shared.MealServices;
using OnlineServices.Shared.MealServices.Interfaces;
using System;

namespace MealServices.BusinessLayer.UseCases
{
    public partial class AttendeeRole : IMSAttendeeRole
    {
        private readonly IMSUnitOfWork iMSUnitOfWork;

        public AttendeeRole(IMSUnitOfWork iMSUnitOfWork)
        {
            this.iMSUnitOfWork = iMSUnitOfWork ?? throw new ArgumentNullException(nameof(iMSUnitOfWork));
        }
    }
}
