using capaEF;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class comidaDatos
    {
        public List<Comida> listarComida()
        {
            using (var db = new GescomDBContext())
            {
                return db.Comida.ToList();
            }
        }

        public void agregarComida(Comida comida)
        {
            using (var db = new GescomDBContext())
            {
                db.Comida.Add(comida);
                db.SaveChanges();
            }
        }

        public void editarComida (Comida comida)
        {
            using ( var db = new GescomDBContext())
            {
                db.Comida.Update(comida);
                db.SaveChanges();
            }
        }

        public void eliminarComida (int comidaId)
        {
            using (var db = new GescomDBContext())
            {
                var comida = db.Comida.Find(comidaId);
                if (comida != null)
                {
                    db.Comida.Remove(comida);
                    db.SaveChanges();
                }
            }
        }

        public Comida obtenerComidaPorId(int comidaId)
        {
            using (var db = new GescomDBContext())
            {
                return db.Comida.Find(comidaId);
            }
        }
    }
}
