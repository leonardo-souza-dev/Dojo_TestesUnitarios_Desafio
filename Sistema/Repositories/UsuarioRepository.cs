using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Domain;
using Sistema.Interfaces;

namespace Sistema.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Inserir(string email, string senha)
        {
            Console.WriteLine($"Usuario com email {email} inserido na base");
            return new Usuario();//
        }

        public Usuario Obter(string email)
        {
            return email == "joao@gmail.com" ? new Usuario() : null;//
        }
    }
}
