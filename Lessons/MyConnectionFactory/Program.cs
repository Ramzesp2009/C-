using System;
using System.Data;
using System.Data.Odbc;

#if PC
using System.Data.OleDb;
#endif
using System.Data.SqlClient;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;
using MyConnectionFactory;

Console.WriteLine("***** Very Simple Connection Factory *****\n");
Setup(DataProviderEnum.SqlServer);
#if PC
    Setup(DataProviderEnum.OleDb);
#endif
Setup(DataProviderEnum.Odbc);
Setup(DataProviderEnum.None);

void Setup(DataProviderEnum providerEnum)
{
    IDbConnection myConnection = GetConnection(providerEnum);
    Console.WriteLine($"Your connection is a {myConnection?.GetType().Name ?? "unrecognized type"}");
}

IDbConnection GetConnection(DataProviderEnum dataProvider) => dataProvider switch
{
    DataProviderEnum.SqlServer => new SqlConnection(),
#if PC
    DataProviderEnum.OleDb => new OleDbConnection(),
#endif
    DataProviderEnum.Odbc => new OdbcConnection(),
    _ => null,
};
