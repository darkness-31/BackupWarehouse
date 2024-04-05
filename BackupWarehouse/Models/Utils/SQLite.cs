using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace BackupWarehouse.Models.Utils
{
    public static class SQLite
    {
        private static string _connectionString = $"Data Source={Path.Combine(Environment.CurrentDirectory, "Source", "backup.warehouse")}";
        private static SQLiteConnection DataBase = new SQLiteConnection(_connectionString);

        internal static void Open()
        {
            DataBase.Open();
        }
        internal static void Close() => DataBase.Close();

        internal static DataTable SQLQueryAsDataTable(this string sql)
        {
            var dt = new DataTable();
            var command = new SQLiteCommand(sql, DataBase);
            using (var reader = command.ExecuteReader())
            {
                if (reader.CanGetColumnSchema())
                {
                    dt.Columns.AddRange(
                        reader.GetColumnSchema()
                            .Select(x => new DataColumn(x.ColumnName, x.DataType))
                            .ToArray());
                }
                else
                {
                    dt.Columns.AddRange(Enumerable.Range(0, reader.FieldCount)
                                                  .Select(x => new DataColumn(reader.GetName(x), reader.GetFieldType(x)))
                                                  .ToArray());
                }

                if (!reader.HasRows) return dt;

                while (reader.Read())
                {
                    var row = dt.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var tp = dt.Columns[i].DataType;
                        object temp;
                        if (tp == typeof(DateTime))
                        {
                            temp = reader.GetString(i);
                        }
                        else
                        {
                            temp = reader.GetValue(i);
                        }
                        row[i] = Convert.ChangeType(temp, tp);
                    }
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        internal static void SQLNoneQuery(this string sql)
        {
            new SQLiteCommand(sql, DataBase).ExecuteNonQuery();
        }

        public static T ConvertFromDbVal<T>(this object obj)
        {   
            if (obj == null || obj == DBNull.Value || obj is null)
                return default;

            if (Guid.TryParse(obj.ToString(), out var a))
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(obj);
            } 
            else if (DateTime.TryParse(obj.ToString(), out var b))
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(obj.ToString());
            }

            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}