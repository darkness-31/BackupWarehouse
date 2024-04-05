using BackupWarehouse.Models.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupWarehouse.Models
{
    internal class Account
    {
        internal Guid Id { get; set; }
        internal string Name { get; set; }
        internal string Login { get; set; }
        internal Entity Access { get; set; }


        internal static Account Get(Guid? v)
        {
            if (v == null) return null;

            var sql = $@"SELECT account_id,
                         	    name,
                         	    login,
                         	    e_access
                         FROM account
                         WHERE delete_status_code = 0 AND
                               account_id = '{v}'";
            var rows = sql.SQLQueryAsDataTable().Rows;
            if (rows.Count == 0 ) return null;

            return new Account
            {
                Id = rows[0]["account_id"].ConvertFromDbVal<Guid>(),
                Name = rows[0]["name"].ConvertFromDbVal<string>(),
                Login = rows[0]["login"].ConvertFromDbVal<string>(),
                Access = Entity.Get(Entity.eGroup.access, rows[0]["e_access"].ConvertFromDbVal<int>())
            };
        }

        internal static Account Create(string name, string login, string password, Entity access, Guid createdBy)
        {
            var sql = $@"INSERT INTO account (account_id, name, login, password, e_access, created_by)
                         VALUES ('{Guid.NewGuid()}', '{name}', '{login}', '{password}', {access.Code},'{createdBy}')
                         RETURNING account_id";
            var row = sql.SQLQueryAsDataTable().Rows[0];

            return new Account
            {
                Id = row["account_id"].ConvertFromDbVal<Guid>(),
                Name = name,
                Login = login,
                Access = access
            };
        }

        internal static bool IsExistLogin(string login)
        {
            var sql = $@"SELECT COUNT(*) AS ""count""
                         FROM account
                         WHERE login = '{login}'";
            return sql.SQLQueryAsDataTable().Rows[0]["count"].ConvertFromDbVal<int>() > 0;
        }
    }
}
