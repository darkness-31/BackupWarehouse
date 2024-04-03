using System;
using System.Collections.Generic;
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
    }
}
