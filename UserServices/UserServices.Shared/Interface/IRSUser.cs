using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.Interface
{
    internal interface IRSUser
    {
        int GetID();

        bool Login();

        void Logout();
    }
}