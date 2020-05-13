using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatUDP_1._0
{
    class GerenciadorUDP
    {
        public delegate void ProcessarMensagemRecebida(string Buffer);

        public class GerenciadoUDP
        {
            public int Porta { get; set; }
            public IPAddress iPAdress { get; set; }
            public Encoding Encoding { get; set; }

            public ProcessarMensagemRecebida ProcessarMensagem;

            private Thread treadSeverUDP;
            private volatile bool alive;
            private string name;

            public GerenciadoUDP() { }

            public GerenciadoUDP(String Nome, string ip)
            {
                this.Encoding = Encoding.UTF8;
                this.alive = true;
                this.name = Nome;
                this.iPAdress = IPAddress.Parse(ip);
            }


            public void Start()
            {
                this.treadSeverUDP = new Thread(() => StartListener());
                this.treadSeverUDP.IsBackground = true;
                this.treadSeverUDP.Name = "Server_UDP" + this.name;
                this.treadSeverUDP.Start();
                while (!treadSeverUDP.IsAlive) ;
            }
            public void Stop()
            {
                this.alive = false;
                this.treadSeverUDP.Join(200);
                if (this.treadSeverUDP.IsAlive)
                {
                    this.treadSeverUDP.Abort();
                }
                this.ProcessarMensagem = null;
            }


            private void StartListener()
            {
                //fecha e limpa a variavel assim que ela terminar o bloco

                using (UdpClient listener = new UdpClient(Porta))
                {
                    IPEndPoint groupEP;
                    groupEP = new IPEndPoint(iPAdress, Porta);

                    try
                    {
                        while (this.alive)
                        {
                            //impede que thread fique totalmete bloqueada
                            if (listener.Available > 0 && this.alive)
                            {
                                byte[] bytes = listener.Receive(ref groupEP);
                                string msg = this.Encoding.GetString(bytes, 0, bytes.Length);
                                this.ProcessarMensagem(msg);
                            }
                            else
                            {
                                Thread.Sleep(500);
                            }
                        }

                    }
                    catch (ThreadAbortException)
                    {
                        Thread.ResetAbort();

                        throw;
                    }
                    finally
                    {
                        listener.Close();
                    }

                }
            }

            public static void EnviarMensagemUDP(String ip, int Porta, String Mensagem)
            {
                GerenciadoUDP enviar = new GerenciadoUDP();
                byte[] buffer = UTF8Encoding.UTF8.GetBytes(Mensagem);
                enviar.send(buffer, ip, Porta);
            }
            //classe de envio
            private void send(byte[] buffer, string ip, int Porta)
            {
                Socket socket = null; //gera um socket 

                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    IPAddress ipAdress = IPAddress.Parse(ip); //passa o valor do ip mesmo com o ponto
                    IPEndPoint ep = new IPEndPoint(ipAdress, Porta);
                    socket.SendTo(buffer, ep);// envia a mensagem em formato buffer
                    Thread.Sleep(15);
                }
                catch (Exception e)
                {

                    // ;
                }
                finally
                {
                    if (socket != null)
                    {
                        socket.Close();// se socket aberto depois de enviar mensagem fecha
                        socket.Dispose(); // limpa Socket
                    }
                }
            }



        }

    }
}
