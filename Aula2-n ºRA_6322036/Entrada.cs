using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_n_ºRA_6322036
{
    internal class Entrada
    {
        double valor;
        string poltrona;
        DateTime horario; 

        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return this.valor;
        }

        public void SetPoltrona(string poltrona)
        {
            this.poltrona = poltrona;
        }
        public string GetPoltronar()
        {
            return this.poltrona;
        }

        public void SetHorario(DateTime horario)
        {
            this.horario = horario;
        }
        public DateTime GetHorario()
        {
            return this.horario;
        }



    }
}
