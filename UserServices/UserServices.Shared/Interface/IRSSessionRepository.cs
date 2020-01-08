using System;
using System.Collections.Generic;
using System.Text;
using UserServices.Shared.TransferObject;
using OnlineServices.Shared.DataAccessHelpers;

namespace UserServices.Shared.Interface
{
    internal interface IRSSessionRepository : OnlineServices.Shared.DataAccessHelpers.IRepository<SessionTO, int>
    {
        IEnumerable<UserTO> GetStudents(SessionTO session);

        IEnumerable<DateTime> GetDates(SessionTO session);
    }
}