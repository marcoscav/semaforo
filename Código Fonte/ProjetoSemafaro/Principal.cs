using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSemafaro.componentes;

namespace ProjetoSemafaro
{
    public partial class Principal : Form
    {
        Semaforo semaforo = new Semaforo();
        private List<Carro> listaCarrosXc = new List<Carro>();
        private List<Carro> listaCarrosXb = new List<Carro>();

        private List<Carro> listaCarrosYe = new List<Carro>();
        private List<Carro> listaCarrosYd = new List<Carro>();

        public Principal()
        {
            InitializeComponent();

            //Setando dados do semáfaro
            semaforo.setTempoAbertoX(80);
            semaforo.setTempoAbertoY(50);
            semaforo.setLabel(label);
            semaforo.ImagemSemaforoX = picSemaforoX;
            semaforo.ImagemSemaforoY = picSemaforoY;
            GerarTrafego("X");
            GerarTrafego("Y");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            semaforo.atualiza();
            atualizarCarros();
        }

        private void atualizarCarros()
        {
            Console.WriteLine("\nDEBUG\n->listaCarrosXc");
            Carro carroSerDestruido = null;
            foreach (Carro carro in listaCarrosXc)
            {
                if (carro.isFinalizou())
                {
                    carro.destruirRadio();
                    carroSerDestruido = carro;
                }
                else
                {
                    carro.atualizar();
                    Console.WriteLine("->" + carro.ToString());
                }
            }
            if (carroSerDestruido != null)
            {
                listaCarrosXc.Remove(carroSerDestruido);
            }
            carroSerDestruido = null;
            Console.WriteLine("->listaCarrosXb");
            foreach (Carro carro in listaCarrosXb)
            {
                if (carro.isFinalizou())
                {
                    carro.destruirRadio();
                    carroSerDestruido = carro;
                }
                else
                {
                    carro.atualizar();
                    Console.WriteLine("->" + carro.ToString());
                }
            }
            if (carroSerDestruido != null)
            {
                listaCarrosXb.Remove(carroSerDestruido);
            }

            Console.WriteLine("->listaCarrosYe");
            foreach (Carro carro in listaCarrosYe)
            {
                if (carro.isFinalizou())
                {
                    carro.destruirRadio();
                    carroSerDestruido = carro;
                }
                else
                {
                    carro.atualizar();
                    Console.WriteLine("->" + carro.ToString());
                }
            }

            if (carroSerDestruido != null)
            {
                listaCarrosXb.Remove(carroSerDestruido);
            }
            Console.WriteLine("->listaCarrosYd");
            foreach (Carro carro in listaCarrosYd)
            {
                if (carro.isFinalizou())
                {
                    carro.destruirRadio();
                    carroSerDestruido = carro;
                }
                else
                {
                    carro.atualizar();
                    Console.WriteLine("->" + carro.ToString());
                }
            }

            if (carroSerDestruido != null)
            {
                listaCarrosXb.Remove(carroSerDestruido);
            }
        }

        private void GerarTrafego(String direcao)
        {
            int i = 0;
            for (i = 0; i < 3; i++)
            {
                Random randNum = new Random();
                int velocidade = randNum.Next(10, 20);
                int faixa = new Random().Next(0, 2);
                Carro carro = GeradorDeCarros.gerarCarro(velocidade, direcao, semaforo, faixa);
                this.Controls.Add(carro.getRadio());
                if (direcao == "X")
                {
                    if (faixa == 0)
                    {
                        if (listaCarrosXc.Count < 8)
                            listaCarrosXc.Add(carro);
                    }
                    else
                    {
                        if (listaCarrosXb.Count < 7)
                            listaCarrosXb.Add(carro);
                    }
                        
                }
                else
                {
                    if (faixa == 0)
                        if (listaCarrosYe.Count < 6)
                            listaCarrosYe.Add(carro);
                    else
                        if (listaCarrosYd.Count < 5)
                            listaCarrosYd.Add(carro);
                }
            }
        }
        private void tmCarros_Tick(object sender, EventArgs e)
        {
            GerarTrafego("X");
            GerarTrafego("Y");
        }
    }
}
