﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class UsuarioDto
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Clave { get; set; }
        public int RolId { get; internal set; }
    }
}
