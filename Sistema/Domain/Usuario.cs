using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Domain
{
    public class Usuario
    {
        public int IdUsuario { get { return new Random().Next(1, 100); } }
    }
}
