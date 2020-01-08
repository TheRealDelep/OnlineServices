using System;
using System.Collections.Generic;
using System.Text;
using UserServices.DataLayer.Entities;
using UserServices.Shared.TransferObject;

namespace UserServices.DataLayer.Extensions
{
    public static class SessionExtensions
    {
        public static SessionTO ToTtansfertObject(this SessionEF session)
        {
            throw new NotImplementedException();
        }

        public static SessionEF ToEF(this SessionTO session)
        {
            throw new NotImplementedException();
        }
    }
}