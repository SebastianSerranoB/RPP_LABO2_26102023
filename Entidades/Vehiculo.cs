using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.esAWD = false;
            this.numeroDeChasis = Guid.NewGuid();
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = esAWD;
        }

        protected abstract string Tipo { get; }
       
         public EPropulsion Propulsion { get { return propulsion; } }


        /// <summary>
        /// Retorna un string que contiene un mensaje que describe los atributos que componen al vehiculo.
        /// </summary>
        /// <returns></returns>
        protected virtual string GetInfo()
        {
            string mensaje = string.Format("{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}", this.Tipo, this.Propulsion, this.esAWD, this.numeroDeChasis);
            return mensaje;
        }

        public override string ToString()
        {
            return this.GetInfo();
        }


        /// <summary>
        /// Compara si los dos parametros recibidos son del mismo tipo y su numero de chasis coincide, si es asi, son el mismo vehiculo.
        /// </summary>
        /// <param name="v1">parametro a comparar</param> 
        /// <param name="v2">parametro a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }



    }
}