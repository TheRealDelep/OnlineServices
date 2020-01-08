using System;
using System.Collections.Generic;
using System.Text;

namespace UserServices.Shared.Interface
{
    internal interface IRSUser
    {
        bool Login();

        bool Logout();
    }
}