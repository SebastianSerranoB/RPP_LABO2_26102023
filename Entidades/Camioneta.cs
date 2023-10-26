using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;


        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }


        protected override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.GetInfo());
            if (this.cabinaSimple)
            {
                sb.AppendLine($"con cabina simple");
            }
            else
            {
                sb.AppendLine($"con cabina doble");
            }
          
            return sb.ToString();
        }


    }
}
