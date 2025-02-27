using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
    {
        const double precoPorDia = 90.0; // Valor diário do aluguel
        const double precoPorKm = 0.50;  // Valor por quilômetro rodado

        int kmPercorridos = quilometragemFinal - quilometragemInicial;
        double total = (dias * precoPorDia) + (kmPercorridos * precoPorKm);

        return total;
    }
}
}
