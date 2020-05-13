using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChatUDP_1._0.GerenciadorUDP;

namespace ChatUDP_1._0
{
    public partial class Form1 : Form
    {
        private GerenciadoUDP udpSever;
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarMensagem(String msg)
        {
            if (string.IsNullOrEmpty(txtQuadroMensagens.Text))
            {
                txtQuadroMensagens.Text = msg;
            }
            else
            {
                txtQuadroMensagens.Text = txtQuadroMensagens.Text + System.Environment.NewLine + msg;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmeuIP.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtminhaPorta.Text))
            {
                MessageBox.Show("Preencha os dados Corretamente");
                return;
            }



            udpSever = new GerenciadoUDP("UDP_CHAT", txtmeuIP.Text);
            udpSever.Porta = Int32.Parse(txtminhaPorta.Text);
            udpSever.ProcessarMensagem = AtualizarMensagem;
            udpSever.Start();
            txtminhaPorta.Enabled = false;
            txtmeuIP.Enabled = false;
            txtUsuario.Enabled = false;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string msg = txtUsuario.Text + ":" + txtPortaDestino.Text;

            if (String.IsNullOrEmpty(txtIpDestino.Text) || String.IsNullOrEmpty(txtDestinoPorta.Text))
            {
                MessageBox.Show("Preencha os dados Corretamente");
                return;
            }

            GerenciadoUDP.EnviarMensagemUDP(txtIpDestino.Text, Int32.Parse(txtDestinoPorta.Text), msg);

            AtualizarMensagem(msg);
        }
    }
}
