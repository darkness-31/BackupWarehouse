using BackupWarehouse.Models.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackupWarehouse.Models
{
    internal class Product
    {
        internal Guid Id { get; set; }
        internal string Name { get; set; }
        internal Entity Status { get; set; }
        internal ObservableCollection<Entity> Tags { get; set; } = new ObservableCollection<Entity>();
        internal DateTime Acceptance { get; set; }
        internal DateTime? Departure { get; set; }
        internal DateTime CreatedAt { get; set; }
        internal Account CreatedBy { get; set; }
        internal DateTime? ModifiedAt { get; set; }
        internal Account ModifiedBy { get; set; }

        internal delegate void ProductUpdateHandler();
        internal static event ProductUpdateHandler ProductUpdateEvent;

        internal static Product[] GetCollection(string search = "")
        {
            var sql = new StringBuilder($@"SELECT product_id,
                                                  name,
                                                  e_status,
                                                  acceptance,
                                                  departure,
                                                  created_by,
                                                  created_at,
                                                  modified_by,
                                                  modified_at
                                           FROM product
                                           WHERE delete_status_code = 0");
            if (!string.IsNullOrEmpty(search))
            {
                sql.Append($" AND LOWER(name) LIKE '%{search.ToLower()}%'");
            }

            var rows = sql.ToString().SQLQueryAsDataTable().Rows;
            if (rows.Count == 0) return new Product[] { };
            Product[] products = new Product[rows.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                products[i] = new Product()
                {
                    Id = rows[i]["product_id"].ConvertFromDbVal<Guid>(),
                    Name = rows[i]["name"].ConvertFromDbVal<string>(),
                    Status = Entity.Get(Entity.eGroup.status, rows[i]["e_status"].ConvertFromDbVal<int>()),
                    Acceptance = rows[i]["acceptance"].ConvertFromDbVal<DateTime>(),
                    Departure = rows[i]["departure"].ConvertFromDbVal<DateTime>(),
                    CreatedAt = rows[i]["created_at"].ConvertFromDbVal<DateTime>(),
                    CreatedBy = Account.Get(rows[i]["created_by"].ConvertFromDbVal<Guid?>()),
                    ModifiedAt = rows[i]["modified_at"].ConvertFromDbVal<DateTime?>(),
                    ModifiedBy = Account.Get(rows[i]["modified_by"].ConvertFromDbVal<Guid?>())
                };
                products[i].GetTags();
            };

            return products;
        }

        internal ObservableCollection<Entity> GetTags()
        {
            var sql = $@"SELECT entity_id,
                         	    code, 
                         	    name,
                         	    meaning
                         FROM entity INNER JOIN
                         	    product_tag ON entity.entity_id = product_tag.e_tag AND 
                         	   				   product_tag.product_id = '{Id}' AND
                         	   				   product_tag.delete_status_code = 0";
            var rows = sql.SQLQueryAsDataTable().Rows;
            if (rows.Count == 0) return Tags;

            foreach (DataRow row in rows)
            {
                Tags.Add(new Entity()
                {
                    Id = row["entity_id"].ConvertFromDbVal<Guid>(),
                    Code = row["code"].ConvertFromDbVal<int>(),
                    Name = row["name"].ConvertFromDbVal<string>(),
                    Meaning = row["meaning"].ConvertFromDbVal<string>()
                });
            }

            return Tags;
        }

        internal static void Create(Product product)
        {
            var sql = $@"INSERT INTO product (product_id, name, e_status, acceptance, departure, created_by, created_at, modified_by, modified_at)
                         VALUES ('{product.Id}','{product.Name}',{product.Status.Code},'{product.Acceptance}','{product.Departure}','{product.CreatedBy.Id}','{product.CreatedAt}','{product.ModifiedBy?.Id ?? null}','{product.ModifiedAt}')";
            sql.SQLNoneQuery();

            if (product.Tags.Count > 0)
            {
                var sqlBuilder = new StringBuilder($@"INSERT INTO product_tag (product_id, e_tag, created_by, created_at, modified_by, modified_at) VALUES ");
                var values = new ObservableCollection<string>();
                foreach (Entity tag in product.Tags)
                {
                    values.Add($"('{product.Id}','{tag.Id}','{product.CreatedBy.Id}','{product.CreatedAt}','{product.ModifiedBy?.Id ?? null}','{product.ModifiedAt}')");
                }
                sqlBuilder.Append(string.Join(", ", values));

                sqlBuilder.ToString().SQLNoneQuery();
            }
        }

        internal void LinkTag(Entity ent)
        {
            var sql = $@"SELECT COUNT(*) AS ""count""
                         FROM product_tag
                         WHERE delete_status_code = 1 AND 
                         	   product_id = '{Id}' AND 
                         	   e_tag = '{ent.Id}'";
            var countDelTag = sql.SQLQueryAsDataTable().Rows[0]["count"].ConvertFromDbVal<int>();
            
            if (countDelTag == 1)
            {
                sql = $@"UPDATE product_tag 
                         SET delete_status_code = 0
                         WHERE product_id = '{Id}' AND 
                               e_tag = '{ent.Id}'";
                sql.SQLNoneQuery();
            }
            else
            {
                sql = $@"INSERT INTO product_tag (product_id, e_tag, created_by, created_at, modified_by, modified_at) 
                         VALUES ('{Id}','{ent.Id}','{CreatedBy.Id}','{CreatedAt}','{ModifiedBy?.Id ?? null}','{ModifiedAt}')";
                sql.SQLNoneQuery();
            }

            Tags.Add(ent);
        }

        internal void DeleteTag(Entity ent)
        {
            var sql = $@"UPDATE product_tag 
                         SET delete_status_code = 1
                         WHERE product_id = '{Id}' AND 
                               e_tag = '{ent.Id}'";
            sql.SQLNoneQuery();
            Tags.Remove(ent);
        }

        internal void Delete()
        {
            var sql = $@"UPDATE product 
                         SET delete_status_code = 1
                         WHERE product_id = '{Id}'";
            sql.SQLNoneQuery();
            ProductUpdateEvent?.Invoke();
        }
    }
}