﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public class CajonLlenoException : Exception
    {
        public CajonLlenoException()
            : base("Se intento agregar un elemento a un cajon lleno")
        {

        }
    }
}
