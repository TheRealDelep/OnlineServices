using OnlineServices.Shared.DataAccessHelpers;
using System.Collections.Generic;
using UserServices.Shared.TransferObject;

namespace UserServices.Shared.Interface
{
    internal interface IUserRepository : OnlineServices.Shared.DataAccessHelpers.IRepository<UserTO, int>
    {
        IEnumerable<SessionTO> GetSessions(UserTO user);

        bool IsInSession(UserTO user, SessionTO session);
    }
}