using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_n_ºRA_6322036
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string classificacao;

        public void Receber(string ti, string si, string ge, string cla)
        {
            this.titulo = ti;
            this.sinopse = si;
            this.genero = ge;
            this.classificacao = cla;
        }

        public string Mostrar()
        {
            return "\nTítulo: " + this.titulo + "\nSinopse: " + this.sinopse + "\nGênero: " + this.genero + "\nClassificação: " + this.classificacao;  
        }

    }
}
