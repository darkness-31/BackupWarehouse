using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupWarehouse.Models
{
    internal class Entity
    {

        internal Guid Id { get; set; }
        internal int Code { get; set; }
        internal string Name { get; set; }
        internal string Meaning { get; set; }

    }
}
