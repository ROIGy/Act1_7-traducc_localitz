namespace Prova_Avaluacio
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iniciarUnaPartidaToolStripMenuItem = new ToolStripMenuItem();
            sortirDeLaplicacióToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtJugades = new TextBox();
            txtPerdudes = new TextBox();
            txtGuanyades = new TextBox();
            btnPedra = new Button();
            btnPaper = new Button();
            btnTisores = new Button();
            btnLizard = new Button();
            btnSpock = new Button();
            label8 = new Label();
            txtResultat = new TextBox();
            label9 = new Label();
            label10 = new Label();
            picBoxJugador = new PictureBox();
            picBoxCPU = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iniciarUnaPartidaToolStripMenuItem, sortirDeLaplicacióToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iniciarUnaPartidaToolStripMenuItem
            // 
            iniciarUnaPartidaToolStripMenuItem.Name = "iniciarUnaPartidaToolStripMenuItem";
            iniciarUnaPartidaToolStripMenuItem.Size = new Size(143, 24);
            iniciarUnaPartidaToolStripMenuItem.Text = "Iniciar una partida";
            iniciarUnaPartidaToolStripMenuItem.Click += iniciarUnaPartidaToolStripMenuItem_Click;
            // 
            // sortirDeLaplicacióToolStripMenuItem
            // 
            sortirDeLaplicacióToolStripMenuItem.Name = "sortirDeLaplicacióToolStripMenuItem";
            sortirDeLaplicacióToolStripMenuItem.Size = new Size(151, 24);
            sortirDeLaplicacióToolStripMenuItem.Text = "Sortir de l'aplicació";
            sortirDeLaplicacióToolStripMenuItem.Click += sortirDeLaplicacióToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(216, 43);
            label1.Name = "label1";
            label1.Size = new Size(425, 30);
            label1.TabIndex = 25;
            label1.Text = "Pedra, Paper, Tisores, Lizard, Spock";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(255, 86);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 24;
            label2.Text = "Jordan Roig";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(423, 88);
            label3.Name = "label3";
            label3.Size = new Size(174, 23);
            label3.TabIndex = 23;
            label3.Text = "07/04/2025";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(73, 125);
            label4.Name = "label4";
            label4.Size = new Size(190, 37);
            label4.TabIndex = 22;
            label4.Text = "Escull la teva jugada";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(696, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 21;
            label5.Text = "Jugades fetes";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(655, 125);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 20;
            label6.Text = "Guanyades";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(755, 125);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 19;
            label7.Text = "Perdudes";
            // 
            // txtJugades
            // 
            txtJugades.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtJugades.Location = new Point(703, 70);
            txtJugades.Name = "txtJugades";
            txtJugades.ReadOnly = true;
            txtJugades.Size = new Size(92, 27);
            txtJugades.TabIndex = 18;
            // 
            // txtPerdudes
            // 
            txtPerdudes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPerdudes.Location = new Point(753, 151);
            txtPerdudes.Name = "txtPerdudes";
            txtPerdudes.ReadOnly = true;
            txtPerdudes.Size = new Size(92, 27);
            txtPerdudes.TabIndex = 17;
            // 
            // txtGuanyades
            // 
            txtGuanyades.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtGuanyades.Location = new Point(655, 151);
            txtGuanyades.Name = "txtGuanyades";
            txtGuanyades.ReadOnly = true;
            txtGuanyades.Size = new Size(92, 27);
            txtGuanyades.TabIndex = 16;
            // 
            // btnPedra
            // 
            btnPedra.Location = new Point(24, 165);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(75, 29);
            btnPedra.TabIndex = 15;
            btnPedra.Text = "Pedra";
            btnPedra.Click += btnPedra_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(124, 165);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(75, 31);
            btnPaper.TabIndex = 14;
            btnPaper.Text = "Paper";
            btnPaper.Click += btnPaper_Click;
            // 
            // btnTisores
            // 
            btnTisores.Location = new Point(224, 167);
            btnTisores.Name = "btnTisores";
            btnTisores.Size = new Size(75, 29);
            btnTisores.TabIndex = 13;
            btnTisores.Text = "Tisores";
            btnTisores.Click += btnTisores_Click;
            // 
            // btnLizard
            // 
            btnLizard.Location = new Point(64, 270);
            btnLizard.Name = "btnLizard";
            btnLizard.Size = new Size(75, 32);
            btnLizard.TabIndex = 12;
            btnLizard.Text = "Lizard";
            btnLizard.Click += btnLizard_Click;
            // 
            // btnSpock
            // 
            btnSpock.Location = new Point(177, 270);
            btnSpock.Name = "btnSpock";
            btnSpock.Size = new Size(75, 32);
            btnSpock.TabIndex = 11;
            btnSpock.Text = "Spock";
            btnSpock.Click += btnSpock_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(373, 143);
            label8.Name = "label8";
            label8.Size = new Size(174, 23);
            label8.TabIndex = 10;
            label8.Text = "Guanyador:";
            // 
            // txtResultat
            // 
            txtResultat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResultat.Location = new Point(357, 169);
            txtResultat.Name = "txtResultat";
            txtResultat.ReadOnly = true;
            txtResultat.Size = new Size(211, 27);
            txtResultat.TabIndex = 9;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.Location = new Point(373, 280);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 8;
            label9.Text = "Has tret:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.Location = new Point(655, 280);
            label10.Name = "label10";
            label10.Size = new Size(142, 23);
            label10.TabIndex = 7;
            label10.Text = "La màquina ha tret:";
            // 
            // picBoxJugador
            // 
            picBoxJugador.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picBoxJugador.Location = new Point(336, 312);
            picBoxJugador.Name = "picBoxJugador";
            picBoxJugador.Size = new Size(158, 160);
            picBoxJugador.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxJugador.TabIndex = 6;
            picBoxJugador.TabStop = false;
            // 
            // picBoxCPU
            // 
            picBoxCPU.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picBoxCPU.Location = new Point(655, 312);
            picBoxCPU.Name = "picBoxCPU";
            picBoxCPU.Size = new Size(164, 160);
            picBoxCPU.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCPU.TabIndex = 5;
            picBoxCPU.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pedraImatge;
            pictureBox1.Location = new Point(35, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lizardImatge;
            pictureBox2.Location = new Point(64, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tisoraImatge;
            pictureBox3.Location = new Point(230, 200);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.paperImatge;
            pictureBox4.Location = new Point(135, 200);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.spockImatge;
            pictureBox5.Location = new Point(177, 317);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(874, 504);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(picBoxCPU);
            Controls.Add(picBoxJugador);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtResultat);
            Controls.Add(label8);
            Controls.Add(btnSpock);
            Controls.Add(btnLizard);
            Controls.Add(btnTisores);
            Controls.Add(btnPaper);
            Controls.Add(btnPedra);
            Controls.Add(txtGuanyades);
            Controls.Add(txtPerdudes);
            Controls.Add(txtJugades);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iniciarUnaPartidaToolStripMenuItem;
        private ToolStripMenuItem sortirDeLaplicacióToolStripMenuItem;
        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
        private TextBox txtJugades, txtPerdudes, txtGuanyades, txtResultat;
        private Button btnPedra, btnPaper, btnTisores, btnLizard, btnSpock;
        private PictureBox picBoxJugador, picBoxCPU, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5;
    }
}