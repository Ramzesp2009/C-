using System;
using System.Collections.Generic;
using System.Text;

namespace MyConnectionFactory;

enum DataProviderEnum
{
    SqlServer,
#if PC
    OleDb,
#endif
    Odbc,
    None
}
