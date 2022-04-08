using Examen2RAD.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen2RAD.Controller
{
     public static class Db
    {
        public static SQLiteAsyncConnection dbconexion;

        public static void conexion(string dbpath)
        {
            dbconexion = new SQLiteAsyncConnection(dbpath);

            dbconexion.CreateTableAsync<Pagos>();
        }
    }
}
