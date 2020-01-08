using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserServices.DataLayer.Entities;
using UserServices.Shared.TransferObject;

namespace UserServices.DataLayer.Extensions
{
    public static class UserExtensions
    {
        public static UserTO ToTransfertObject(this UserEF user)
        {
            return new UserTO
            {
                ID = user.Id,
                Name = user.Name,
                Company = user.Company,
                Email = user.Email,
                Role = user.Role,
                IsActivated = user.IsActivated,
                Sessions = user.UserSessions.Select(x => x.Session.ToTtansfertObject()).ToList()
            };
        }

        //public static UserEF ToEF(this UserTO user)
        //{
        //    return new UserEF
        //    {
        //        Id = user.ID,
        //        Name = user.Name,
        //        Company = user.Company,
        //        Email = user.Email,
        //        Role = user.Role,
        //        IsActivated = user.IsActivated,
        //        UserSessions = user.Sessions.Select(x => x.S.ToTtansfertObject()).ToList()
        //    };
        //}

        //public static UserEF UpdateFromDetached(this UserEF AttachedEF, UserEF DetachedEF)
    }
}