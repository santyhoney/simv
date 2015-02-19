﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINISIMVER.Modelos
{
    public class EntidadFederativa
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }

    }
}
