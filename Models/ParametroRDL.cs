using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AppOwnsData.Models
{
    [Serializable]
    [DataContract]
    public class ParametroRDL
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Valor { get; set; }

        public ParametroRDL(string nombre, string valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
