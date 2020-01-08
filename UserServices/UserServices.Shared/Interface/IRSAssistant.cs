using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace UserServices.Shared.Interface
{
    internal interface IRSAssistant
    {
        bool CreateUser();

        void DeleteUser();

        void ReadExcel(Workbook excelFile);
    }
}