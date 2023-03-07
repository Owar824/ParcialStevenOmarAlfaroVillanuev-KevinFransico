using Parcial1StevenOmarAlfaroVillanueva.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1StevenOmarAlfaroVillanueva.Negocio

{
    public class ClsUsuario
    {
        public bool Acceso(Usuario user)
        {
            if (user.Nombre == "steven" && user.Contraseña == 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
