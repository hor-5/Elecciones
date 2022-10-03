using Elecciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.DataStore
{
    public class DBUsuarios
    {
        private List<Usuario> usuarios = new List<Usuario>() {
            new Usuario(){idUsuario = 01,nombreUsuario="kleiva",clave="1234",esSuperUsuario=false , mesaAsignada=8755},
            new Usuario(){idUsuario = 01,nombreUsuario="akloster",clave="1234",esSuperUsuario=false , mesaAsignada=9015},
            new Usuario(){idUsuario = 01,nombreUsuario="plopez",clave="1234",esSuperUsuario=true}
        };

        public List<Usuario> getUsuarios() {
            return this.usuarios;
        }

        
    }
}
