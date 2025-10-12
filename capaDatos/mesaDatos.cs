using capaEntidad;
using capaEF;
using System.Collections.Generic;
using System.Linq;

namespace capaDatos
{
    public class mesaDatos
    {
        public List<Mesa> listarMesas()
        {
            using (var db = new GescomDBContext())
            {
                return db.Mesa.ToList();
            }
        }

        public void agregarMesa(Mesa mesa)
        {
            using (var db = new GescomDBContext())
            {
                db.Mesa.Add(mesa);
                db.SaveChanges();
            }
        }

        public void editarMesa(Mesa mesa)
        {
            using (var db = new GescomDBContext())
            {
                db.Mesa.Update(mesa);
                db.SaveChanges();
            }
        }

        public void eliminarMesa(int mesaId)
        {
            using (var db = new GescomDBContext())
            {
                var mesa = db.Mesa.Find(mesaId);
                if (mesa != null)
                {
                    db.Mesa.Remove(mesa);
                    db.SaveChanges();
                }
            }
        }

        public Mesa obtenerMesaPorId(int mesaId)
        {
            using (var db = new GescomDBContext())
            {
                return db.Mesa.Find(mesaId);
            }
        }
    }
}
