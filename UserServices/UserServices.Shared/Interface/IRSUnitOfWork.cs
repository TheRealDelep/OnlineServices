using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.Interface
{
    internal interface IRSUnitOfWork
    {
        public IRSSessionRepository SessionRepository { get; }
        public IRSUserRepository UserRepository { get; }

        void Dispose();

        void Save();
    }
}