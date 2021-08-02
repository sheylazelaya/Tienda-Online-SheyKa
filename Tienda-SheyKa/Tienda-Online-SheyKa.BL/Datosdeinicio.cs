using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Online_SheyKa.BL
{
    public class Datosdeinicio: CreateDatabaseIfNotExists<Contexto>
    {


        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.contrasena = Encriptar.CodificarContrasena("123");

            contexto.Usuarios.Add(nuevoUsuario);
            base.Seed(contexto);
        }
    }
}
