﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtividadeBancoCarros.Models
{
    public class ControleUsuario
    {
        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }
    }
}