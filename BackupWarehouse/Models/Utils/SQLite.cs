using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BackupWarehouse.Models.Utils
{
    public static class SQLite
    {
        private static string _connectionString =
            $"Data Source={Path.Combine(Environment.CurrentDirectory, "Source", "backup.warehouse")}";

        private static SqliteConnection DataBase = new SqliteConnection(_connectionString);

        internal static void Open() => DataBase.Open();
        internal static void Close() => DataBase.Close();

        internal static DataTable SQLQueryAsDataTable(this string sql)
        {
            var dt = new DataTable();
            var command = new SqliteCommand(sql, DataBase);
            using (var reader = command.ExecuteReader())
            {
                dt.Columns.AddRange(
                    reader.GetColumnSchema()
                        .Select(x => new DataColumn(x.ColumnName, x.DataType))
                        .ToArray());

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var row = dt.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var tp = dt.Columns[i].DataType;
                            row[i] = Convert.ChangeType(reader.GetValue(i), tp);
                        }
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }

    }
}