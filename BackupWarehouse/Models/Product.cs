using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupWarehouse.Models
{
    internal class Product
    {
        internal Guid Id { get; set; }
        internal string Name { get; set; }
        internal Entity Status { get; set; }
        internal ObservableCollection<Entity> Tags { get; set; }
        internal DateTime Acceptance { get; set; }
        internal DateTime? Departure { get; set; }
        internal DateTime CreatedAt { get; set; }
        internal Account CreatedBy { get; set; }
        internal DateTime? ModifiedAt { get; set; }
        internal Account ModifiedBy { get; set; }

        internal static Product[] GetCollection()
        {

        }
    }
}
