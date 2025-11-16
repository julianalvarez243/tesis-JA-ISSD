using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public  class itemMenuNegocio
    {
        private comidaNegocio comidaNeg = new comidaNegocio();
        private bebidaNegocio bebidaNeg = new bebidaNegocio();

        public List <ItemMenu> listarMenuCompleto()
        {
            var comidas = comidaNeg.listarComida()
                .Select(c => new ItemMenu
                {
                    Nombre = c.Nombre,
                    Descripcion = c.Descripcion,
                    Precio = c.Precio,
                    Tipo = "Comida"
                });
            var bebidas = bebidaNeg.listarBebida() 
                .Select(b => new ItemMenu
                {
                    Nombre = b.Nombre,
                    Descripcion = b.Descripcion,
                    Precio = b.Precio,
                    Tipo = "Bebida"
                });

            return comidas.Concat(bebidas).ToList();    
        }

    }
}
