using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal class RCompras
    {
        private FARMACIA_BUENA__SALUDEntities2 db = new FARMACIA_BUENA__SALUDEntities2();
        public int idCompra { get; set; }
        public int idProveedor { get; set; }
        public string tipoCompra { get; set; }
        public DateTime fechaCompra { get; set; }
        public decimal totalCompra { get; set; }


    }
}
