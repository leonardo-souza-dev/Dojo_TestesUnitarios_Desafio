using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Interfaces
{
    public interface IMensageriaService
    {
        void Enviar(object mensagem);
    }
}
