using System;
using System.Collections.Generic;
using System.Text;

namespace DataProviderFactory;

    enum DataProviderEnum
    {
        SqlServer,
    #if PC
        OleDb,
    #endif
        Odbc
    }
