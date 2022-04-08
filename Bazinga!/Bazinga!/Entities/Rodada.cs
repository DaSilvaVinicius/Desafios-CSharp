using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinga_.Entities
{
    internal class Rodada
    {
        public string? Sheldon { get; set; }
        public string? Raj { get; set; }

        public Rodada(string jogadaSheldon, string jogadaRaj)
        {
            Sheldon = jogadaSheldon;
            Raj = jogadaRaj;
        }

        public string Resultado()
        {
            if (Sheldon == "pedra")
            {
                if (Raj == "papel")
                    return "Raj trapaceou!";
                else if (Raj == "tesoura")
                    return "Bazinga!";
                else if (Raj == "lagarto")
                    return "Bazinga!";
                else if (Raj == "Spock")
                    return "Raj trapaceou!";
            }
            else if (Sheldon == "papel")
            {
                if (Raj == "pedra")
                    return "Bazinga!";
                else if (Raj == "tesoura")
                    return "Raj trapaceou!";
                else if (Raj == "lagarto")
                    return "Raj trapaceou!";
                else if (Raj == "Spock")
                    return "Bazinga!";
            }
            else if (Sheldon == "tesoura")
            {
                if (Raj == "pedra")
                    return "Raj trapaceou!";
                else if (Raj == "papel")
                    return "Bazinga!";
                else if (Raj == "lagarto")
                    return "Bazinga!";
                else if (Raj == "Spock")
                    return "Raj trapaceou!";
            }
            else if (Sheldon == "lagarto")
            {
                if (Raj == "pedra")
                    return "Raj trapaceou!";
                else if (Raj == "papel")
                    return "Bazinga!";
                else if (Raj == "tesoura")
                    return "Raj trapaceou!";
                else if (Raj == "Spock")
                    return "Bazinga";
            }
            else if (Sheldon == "Spock")
            {
                if (Raj == "pedra")
                    return "Bazinga!";
                else if (Raj == "papel")
                    return "Raj trapaceou!";
                else if (Raj == "tesoura")
                    return "Bazinga!";
                else if (Raj == "lagarto")
                    return "Raj trapaceou!";
            }

            return "De novo!";
        }
    }
}
