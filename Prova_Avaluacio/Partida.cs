using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Avaluacio
{

    public enum Jugada
    {
        Pedra,
        Paper,
        Tisora,
        Lizard,
        Spock
    }
    internal class Partida
    {
            public string NomJugador { get; set; }
            public int RondesJugades { get; private set; }
            public int VictoriesJugador { get; private set; }
            public int VictoriesCPU { get; private set; }
            public Jugada UltimaJugadaJugador { get; private set; }
            public Jugada UltimaJugadaCPU { get; private set; }
            public bool PartidaAcabada => VictoriesJugador >= 3 || VictoriesCPU >= 3;

            public (string resultat, string descripcio) JugarRonda(Jugada jugadaJugador)
            {
                if (PartidaAcabada)
                    return ("Partida acabada", "Inicia una nova partida per jugar");

                RondesJugades++;
                UltimaJugadaJugador = jugadaJugador;
                UltimaJugadaCPU = GenerarJugadaCPU();

                var (guanyador, descripcio) = DeterminarGuanyador(UltimaJugadaJugador, UltimaJugadaCPU);

                if (guanyador == "Jugador")
                    VictoriesJugador++;
                else if (guanyador == "CPU")
                    VictoriesCPU++;

                return ($"Guanya {guanyador}", descripcio);
            }

            private (string guanyador, string descripcio) DeterminarGuanyador(Jugada jugador, Jugada cpu)
            {
                if (jugador == cpu)
                    return ("Cap", "Empat - Les mateixes jugades");

                switch (jugador)
                {
                    case Jugada.Pedra when cpu == Jugada.Tisora || cpu == Jugada.Lizard:
                        return ("Jugador", GetDescripcioVictoria(jugador, cpu));
                    case Jugada.Paper when cpu == Jugada.Pedra || cpu == Jugada.Spock:
                        return ("Jugador", GetDescripcioVictoria(jugador, cpu));
                    case Jugada.Tisora when cpu == Jugada.Paper || cpu == Jugada.Lizard:
                        return ("Jugador", GetDescripcioVictoria(jugador, cpu));
                    case Jugada.Lizard when cpu == Jugada.Spock || cpu == Jugada.Paper:
                        return ("Jugador", GetDescripcioVictoria(jugador, cpu));
                    case Jugada.Spock when cpu == Jugada.Tisora || cpu == Jugada.Pedra:
                        return ("Jugador", GetDescripcioVictoria(jugador, cpu));
                    default:
                        return ("CPU", GetDescripcioVictoria(cpu, jugador));
                }
            }

            private string GetDescripcioVictoria(Jugada guanyadora, Jugada perdedora)
            {
                return (guanyadora, perdedora) switch
                {
                    (Jugada.Pedra, Jugada.Tisora) => "La pedra aplasta les tisores",
                    (Jugada.Pedra, Jugada.Lizard) => "La pedra aplasta el llangardaix",
                    (Jugada.Paper, Jugada.Pedra) => "El paper cobreix la pedra",
                    (Jugada.Paper, Jugada.Spock) => "El paper desautoritza Spock",
                    (Jugada.Tisora, Jugada.Paper) => "Les tisores tallen el paper",
                    (Jugada.Tisora, Jugada.Lizard) => "Les tisores decapiten el llangardaix",
                    (Jugada.Lizard, Jugada.Paper) => "El llangardaix menja el paper",
                    (Jugada.Lizard, Jugada.Spock) => "El llangardaix enverina Spock",
                    (Jugada.Spock, Jugada.Tisora) => "Spock destrueix les tisores",
                    (Jugada.Spock, Jugada.Pedra) => "Spock vaporitza la pedra",
                    _ => "Acció desconeguda"
                };
            }

            private Jugada GenerarJugadaCPU()
            {
                Random rnd = new Random();
                return (Jugada)rnd.Next(0, 5);
            }

            public void ReiniciarPartida()
            {
                RondesJugades = 0;
                VictoriesJugador = 0;
                VictoriesCPU = 0;
                UltimaJugadaJugador = default;
                UltimaJugadaCPU = default;
            }
        }
    }

