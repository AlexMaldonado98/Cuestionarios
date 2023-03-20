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

        public List<preguntas> ListarPreguntas()
        {
            var preguntas = from a in db.preguntas
                                select a;
            return preguntas.ToList();
        }

        public List<preguntas> ListarPreguntasWhere(int id)
        {
            var preguntas = from a in db.preguntas
                            where a.idCuestionario == id select a;
            return preguntas.ToList();
        }
        public void Agregar(CUEST_ACCESS.cuestionarios item)
        {
            db.cuestionarios.Add(item);
            db.SaveChanges();
        }

    }
}
