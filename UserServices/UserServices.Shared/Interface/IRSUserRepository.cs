using OnlineServices.Shared.DataAccessHelpers;
using System.Collections.Generic;
using UserServices.Shared.TransferObject;

namespace UserServices.Shared.Interface
{
    internal interface IRSUserRepository : OnlineServices.Shared.DataAccessHelpers.IRepository<UserTO, int>
    {
        IEnumerable<SessionTO> GetSessions(UserTO user);

        IEnumerable<UserTO> GetByRole(UserRole role);

        IEnumerable<UserTO> GetBySession(SessionTO session);

        bool IsInSession(UserTO user, SessionTO session);
    }
}