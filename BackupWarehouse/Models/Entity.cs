using BackupWarehouse.Models.Utils;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace BackupWarehouse.Models
{
    internal class Entity
    {
        internal Guid Id { get; set; }
        internal int Code { get; set; }
        internal string Name { get; set; }
        internal string Meaning { get; set; }

        internal enum eGroup
        {
            tag,
            status,
            access
        }

        internal static Entity Create(eGroup group, string meaning)
        {
            var sql = new StringBuilder($@"INSERT INTO entity (entity_id, code, name, meaning, created_by)
                                           VALUES ('{Guid.NewGuid()}',(SELECT COUNT(*) FROM entity WHERE name = '{group}'),'{group}','{meaning}','{Autification.CurrentAccoutn.Id}')
                                           RETURNING entity_id, 
                                                     code");
            var row = sql.ToString().SQLQueryAsDataTable().Rows[0];
            return new Entity
            {
                Id = row["id"].ConvertFromDbVal<Guid>(),
                Code = row["code"].ConvertFromDbVal<int>(),
                Name = group.ToString(),
                Meaning = meaning
            };
        }
        internal static ObservableCollection<Entity> GetCollection(eGroup group)
        {
            var sql = new StringBuilder($@"SELECT entity_id,
                                          	     code,
                                          	     name,
                                          	     meaning
                                          FROM entity
                                          WHERE name = '{group.ToString()}'");
            var rows = sql.ToString().SQLQueryAsDataTable().Rows;
            if (rows.Count == 0) return new ObservableCollection<Entity>();
            var result = new ObservableCollection<Entity>();
            foreach (DataRow row in rows)
            {
                result.Add(new Entity()
                {
                    Id = row["entity_id"].ConvertFromDbVal<Guid>(),
                    Code = row["code"].ConvertFromDbVal<int>(),
                    Name = row["name"].ConvertFromDbVal<string>(),
                    Meaning = row["meaning"].ConvertFromDbVal<string>()
                });
            }
            return result;
        }
        internal static Entity Get(eGroup group, int code = 0)
        {
            var sql = new StringBuilder($@"SELECT entity_id,
                                          	      meaning
                                           FROM entity
                                           WHERE name = '{group.ToString()}' AND
                                                 code = {code}");
            var row = sql.ToString().SQLQueryAsDataTable().Rows[0];
            return new Entity
            {
                Id = row["entity_id"].ConvertFromDbVal<Guid>(),
                Name = group.ToString(),
                Code = code,
                Meaning = row["meaning"].ConvertFromDbVal<string>()
            };
        }
    }
}
