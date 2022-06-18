using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6 {
    internal interface MaisEstatisticas : Estatisticas {
        double Variancia(double M);
        double DesvioPadrao(double V);
    }
}
