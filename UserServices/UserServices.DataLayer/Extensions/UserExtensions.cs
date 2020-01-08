using System;
using System.Collections.Generic;
using System.Text;
using UserServices.DataLayer.Entities;
using UserServices.Shared.TransferObject;

namespace UserServices.DataLayer.Extensions
{
    public static class UserExtensions
    {
        public static UserTO ToTransferObject(this UserEF userEF)
        {
        }

        //public static UserEF ToEF(this UserTO userTO)

        //public static UserEF UpdateFromDetached(this UserEF AttachedEF, UserEF DetachedEF)
    }
}