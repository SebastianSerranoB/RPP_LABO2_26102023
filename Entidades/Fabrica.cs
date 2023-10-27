using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos 
        {
            get 
            {
                return this.vehiculos;
            }

         }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad) : this()
        { 
            this.capacidad = capacidad; 
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {

            if (fabrica is not null && vehiculo is not null)
            {
               
                if (fabrica.vehiculos.Count < fabrica.capacidad)
                {
                    fabrica.vehiculos.Add(vehiculo);
                    return fabrica;

                    /*if (fabrica.Vehiculos.Count < 1)
                    { 
                        
                    }

                    bool flagEstaEnLaLista = false;
                    foreach (Vehiculo item in fabrica.Vehiculos)
                    {
                        if (item == vehiculo)
                        {
                            return fabrica;
                            flagEstaEnLaLista = true;
                        }
                    }

                    if (flagEstaEnLaLista == false)
                    {
                        fabrica.vehiculos.Add(vehiculo);
                        return fabrica;
                    }*/
                
             
                }


            }

            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica is not null && vehiculo is not null && fabrica.Vehiculos.Count > 0)
            {
                foreach (Vehiculo item in fabrica.Vehiculos)
                {
                    if (item == vehiculo)
                    { 
                        fabrica.vehiculos.Remove(vehiculo);
                        return fabrica;
                    }
                }
            }

            return fabrica;
        }








    }
}
