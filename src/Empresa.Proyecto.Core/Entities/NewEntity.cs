using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Core.Entities
{
    public class NewEntity:BaseEntity
    {
        public string Name { get; set; } = null!;
        public SimpleEntity Opcion { get; set; } = null!;
    }
}