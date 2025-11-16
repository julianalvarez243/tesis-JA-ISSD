using capaEF;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class bebidaDatos
    {
        public List<Bebida> listarBebida()
        {
            using (var db = new GescomDBContext())
            {
                return db.Bebida.ToList();
            }
        }

        public void agregarBebida(Bebida bebida)
        {
            using (var db = new GescomDBContext())
            {
                db.Bebida.Add(bebida);
                db.SaveChanges();
            }
        }

        public void editarBebida (Bebida bebida)
        {
            using ( var db = new GescomDBContext())
            {
                db.Bebida.Update(bebida);
                db.SaveChanges();
            }
        }

        public void eliminarBebida (int bebidaId)
        {
            using (var db = new GescomDBContext())
            {
                var bebida = db.Bebida.Find(bebidaId);
                if (bebida != null)
                {
                    db.Bebida.Remove(bebida);
                    db.SaveChanges();
                }
            }
        }

        public Bebida obtenerBebidaPorId(int bebidaId)
        {
            using (var db = new GescomDBContext())
            {
                return db.Bebida.Find(bebidaId);
            }
        }
    }
}
