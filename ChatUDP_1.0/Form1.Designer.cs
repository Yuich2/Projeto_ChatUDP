namespace ChatUDP_1._0
{
    partial class Form1
    {

        /// Variável de designer necessária.

        private System.ComponentModel.IContainer components = null;


        /// Limpar os recursos que estão sendo usados.

        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuadroMensagens = new System.Windows.Forms.TextBox();
            this.txtmeuIP = new System.Windows.Forms.TextBox();
            this.txtminhaPorta = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtIpDestino = new System.Windows.Forms.TextBox();
            this.txtDestinoPorta = new System.Windows.Forms.TextBox();
            this.txtPortaDestino = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuadroMensagens
            // 
            this.txtQuadroMensagens.Enabled = false;
            this.txtQuadroMensagens.Location = new System.Drawing.Point(12, 54);
            this.txtQuadroMensagens.Multiline = true;
            this.txtQuadroMensagens.Name = "txtQuadroMensagens";
            this.txtQuadroMensagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuadroMensagens.Size = new System.Drawing.Size(398, 192);
            this.txtQuadroMensagens.TabIndex = 0;
            // 
            // txtmeuIP
            // 
            this.txtmeuIP.Location = new System.Drawing.Point(47, 28);
            this.txtmeuIP.Name = "txtmeuIP";
            this.txtmeuIP.Size = new System.Drawing.Size(100, 20);
            this.txtmeuIP.TabIndex = 1;
            this.txtmeuIP.Text = "127.0.0.1";
            // 
            // txtminhaPorta
            // 
            this.txtminhaPorta.Location = new System.Drawing.Point(198, 28);
            this.txtminhaPorta.Name = "txtminhaPorta";
            this.txtminhaPorta.Size = new System.Drawing.Size(52, 20);
            this.txtminhaPorta.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(47, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtIpDestino
            // 
            this.txtIpDestino.Location = new System.Drawing.Point(47, 299);
            this.txtIpDestino.Name = "txtIpDestino";
            this.txtIpDestino.Size = new System.Drawing.Size(100, 20);
            this.txtIpDestino.TabIndex = 1;
            this.txtIpDestino.Text = "127.0.0.1";
            // 
            // txtDestinoPorta
            // 
            this.txtDestinoPorta.Location = new System.Drawing.Point(198, 299);
            this.txtDestinoPorta.Name = "txtDestinoPorta";
            this.txtDestinoPorta.Size = new System.Drawing.Size(52, 20);
            this.txtDestinoPorta.TabIndex = 1;
            // 
            // txtPortaDestino
            // 
            this.txtPortaDestino.Location = new System.Drawing.Point(12, 261);
            this.txtPortaDestino.Name = "txtPortaDestino";
            this.txtPortaDestino.Size = new System.Drawing.Size(300, 20);
            this.txtPortaDestino.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(283, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(103, 46);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(332, 261);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(78, 34);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Porta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 332);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtDestinoPorta);
            this.Controls.Add(this.txtIpDestino);
            this.Controls.Add(this.txtminhaPorta);
            this.Controls.Add(this.txtPortaDestino);
            this.Controls.Add(this.txtmeuIP);
            this.Controls.Add(this.txtQuadroMensagens);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuadroMensagens;
        private System.Windows.Forms.TextBox txtmeuIP;
        private System.Windows.Forms.TextBox txtminhaPorta;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtIpDestino;
        private System.Windows.Forms.TextBox txtDestinoPorta;
        private System.Windows.Forms.TextBox txtPortaDestino;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

