using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Usuario
    {
        public ArrayList Guardarropas = new ArrayList();
        public Guardarropas  CrearGuardarropas()
        {
            Guardarropas value = new Guardarropas();
            value.Usuario = this;
            this.Guardarropas.Add(value);
            return value;
        
        }
        public void EliminarGuardarropas(String nombre)
        {
           for(int i=0;i < this.Guardarropas.Count; i++)
            {
                if (nombre == this.Guardarropas[i].NombreDelGuardarropa)
                {
                    this.Guardarropas.Remove(this.Guardarropas[i]);
                }
            }
            
        }
    }
}
