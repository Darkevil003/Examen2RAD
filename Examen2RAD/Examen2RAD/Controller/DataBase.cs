using Examen2RAD.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen2RAD.Controller
{
    public static class DataBase
    {
       
        public static Task<List<Pagos>> listarPago()
        {
            return Db.dbconexion.Table<Pagos>().ToListAsync();

        }
       
        public static Task<int> Addpago(Pagos pagos)
        {


            return Db.dbconexion.InsertAsync(pagos);

        }
        public static Task<int> Actualizar(Pagos pagos)
        {


            return Db.dbconexion.UpdateAsync(pagos);

        }
        public static Task<Pagos> Obtenerpago(int cid)
        {
            return Db.dbconexion.Table<Pagos>()
                .Where(i => i.Id_pago == cid)
                .FirstOrDefaultAsync();

        }

        public static Task<int> Delregister(Pagos pagos)
        {

            return Db.dbconexion.DeleteAsync(pagos);
        }

        internal static Task Delregister(double v)
        {
            throw new NotImplementedException();
        }
    }
}

