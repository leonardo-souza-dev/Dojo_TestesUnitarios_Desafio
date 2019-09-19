using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema
{
    public class BaseResponse
    {
        public object Dados { get; set; }
        public string Mensagem { get; set; }
    }
}
