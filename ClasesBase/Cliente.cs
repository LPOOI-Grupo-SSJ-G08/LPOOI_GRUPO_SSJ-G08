using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_DNI;

        public string Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }

        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }

        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }

        private string cli_Direccion;

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }

        private string os_CUIT;

        public string Os_CUIT
        {
            get { return os_CUIT; }
            set { os_CUIT = value; }
        }

        private string cli_NroCarnet;

        public string Cli_NroCarnet
        {
            get { return cli_NroCarnet; }
            set { cli_NroCarnet = value; }
        }

        public Cliente(string nombre, string apellido, string dni, string direccion, string cuit, string nroCarnet)
        {
            this.cli_Nombre = nombre;
            this.cli_Apellido = apellido;
            this.cli_DNI = dni;
            this.cli_Direccion = direccion;
            this.os_CUIT = cuit;
            this.cli_NroCarnet = nroCarnet;
        }

        public String MostrarDatos(){
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre: ");
            sb.Append(this.cli_Nombre);
            sb.Append("\nApellido: ");
            sb.Append(this.cli_Apellido);
            sb.Append("\nDNI: ");
            sb.Append(this.cli_DNI);
            sb.Append("\nDireccion: ");
            sb.Append(this.cli_Direccion);
            sb.Append("\nCUIT: ");
            sb.Append(this.os_CUIT);
            sb.Append("\nNumero de Carnet: ");
            sb.Append(this.cli_NroCarnet);
            return sb.ToString();
        }
    }
}
