using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioMaster
{
    public class Usuario
    {
        // Variables
        private string usuario;
        private string tipoAcceso;

        // Constructor
        public Usuario(string usuario, string tipoAcceso)
        {
            this.usuario = usuario;
            this.tipoAcceso = tipoAcceso;
        }

        // Getters
        public string getUsuario()
        {
            return usuario;
        }
        public string getTipoAcceso()
        {
            return tipoAcceso;
        }
    }
}
