using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2RAD.Model
{
    public class Pagos
    {
        [PrimaryKey, AutoIncrement]
        public int Id_pago { get; set; }

        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Phpto_recibo { get; set; }

    }
}
