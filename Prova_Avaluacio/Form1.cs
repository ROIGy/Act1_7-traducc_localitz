namespace Prova_Avaluacio
{
    public partial class Form1 : Form
    {
        private Partida partidaActual;
        private Dictionary<Jugada, Image> imatgesJugades;

        public Form1()
        {
            InitializeComponent();
            partidaActual = new Partida();

            btnPedra.Enabled = false;
            btnPaper.Enabled = false;
            btnTisores.Enabled = false;
            btnLizard.Enabled = false;
            btnSpock.Enabled = false;
        }



        private void iniciarUnaPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerNameDialog form = new PlayerNameDialog();

            form.ShowDialog();

            partidaActual.NomJugador = form.PlayerName;

            btnPedra.Enabled = true;
            btnPaper.Enabled = true;
            btnTisores.Enabled = true;
            btnLizard.Enabled = true;
            btnSpock.Enabled = true;
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            var (resultat, descripcio) = partidaActual.JugarRonda(Jugada.Pedra);
            txtResultat.Text = resultat;
            ActualitzarInterficie();

            if (partidaActual.PartidaAcabada)
            {
                MessageBox.Show(partidaActual.VictoriesJugador >= 3 ?
                    "Has guanyat la partida!" : "Has perdut la partida!");
                neteja();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            var (resultat, descripcio) = partidaActual.JugarRonda(Jugada.Paper);
            txtResultat.Text = resultat;
            ActualitzarInterficie();

            if (partidaActual.PartidaAcabada)
            {
                MessageBox.Show(partidaActual.VictoriesJugador >= 3 ?
                    "Has guanyat la partida!" : "Has perdut la partida!");
                neteja();
            }
        }

        private void btnTisores_Click(object sender, EventArgs e)
        {
            var (resultat, descripcio) = partidaActual.JugarRonda(Jugada.Tisora);
            txtResultat.Text = resultat;
            ActualitzarInterficie();

            if (partidaActual.PartidaAcabada)
            {
                MessageBox.Show(partidaActual.VictoriesJugador >= 3 ?
                    "Has guanyat la partida!" : "Has perdut la partida!");
                neteja();
            }
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
            var (resultat, descripcio) = partidaActual.JugarRonda(Jugada.Lizard);
            txtResultat.Text = resultat;
            ActualitzarInterficie();

            if (partidaActual.PartidaAcabada)
            {
                MessageBox.Show(partidaActual.VictoriesJugador >= 3 ?
                    "Has guanyat la partida!" : "Has perdut la partida!");
                neteja();
            }
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            var (resultat, descripcio) = partidaActual.JugarRonda(Jugada.Spock);
            txtResultat.Text = resultat;
            ActualitzarInterficie();

            if (partidaActual.PartidaAcabada)
            {
                MessageBox.Show(partidaActual.VictoriesJugador >= 3 ?
                    "Has guanyat la partida!" : "Has perdut la partida!");
                neteja();
            }
        }

        private void ActualitzarInterficie()
        {
            txtJugades.Text = partidaActual.RondesJugades.ToString();
            txtGuanyades.Text = partidaActual.VictoriesJugador.ToString();
            txtPerdudes.Text = partidaActual.VictoriesCPU.ToString();

            // Actualitzar imatges de les jugades
            if (partidaActual.RondesJugades > 0)
            {
                picBoxJugador.Image = ObtenirImatgeJugada(partidaActual.UltimaJugadaJugador);
                picBoxCPU.Image = ObtenirImatgeJugada(partidaActual.UltimaJugadaCPU);
            }
        }

        private Image ObtenirImatgeJugada(Jugada jugada)
        {
            if (imatgesJugades == null)
            {
                imatgesJugades = new Dictionary<Jugada, Image>
                {
                    { Jugada.Pedra, Properties.Resources.pedraImatge },
                    { Jugada.Paper, Properties.Resources.paperImatge },
                    { Jugada.Tisora, Properties.Resources.tisoraImatge },
                    { Jugada.Lizard, Properties.Resources.lizardImatge },
                    { Jugada.Spock, Properties.Resources.spockImatge }
                };
            }
            return imatgesJugades[jugada];
        }

        private void neteja()
        {
            txtResultat.Clear();
            txtGuanyades.Clear();
            txtPerdudes.Clear();
            txtJugades.Clear();
            picBoxJugador.Image = null;
            picBoxCPU.Image = null;
        }

        private void sortirDeLaplicacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
