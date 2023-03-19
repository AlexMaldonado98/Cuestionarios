using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUEST_ACCESS
{
    public class Class1
    {
        cuestionariosDBEntities db = new cuestionariosDBEntities();

        public List<cuestionarios> Listar()
        {
            var cuestionarios = from a in db.cuestionarios
                                select a;
            return cuestionarios.ToList();
        }
        public void Agregar(cuestionarios item)
        {
            db.cuestionarios.Add(item);
            db.SaveChanges();
        }
    }
}
