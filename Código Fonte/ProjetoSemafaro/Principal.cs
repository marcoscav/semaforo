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
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoSemafaro
{
    public partial class Principal : Form
    {
        Semaforo semaforo = new Semaforo();
        private List<Carro> listaCarrosXc = new List<Carro>();
        private List<Carro> listaCarrosXb = new List<Carro>();
        private List<Carro> listaCarrosYe = new List<Carro>();
        private List<Carro> listaCarrosYd = new List<Carro>();
        private int contCarrosX;
        private int contCarrosY;

        public Principal()
        {
            InitializeComponent();
            contCarrosX = 0;
            contCarrosY = 0;
            //Setando dados do semáfaro
            semaforo.setTempoAbertoX(Int32.Parse(txtTempoX.Text)*10);
            semaforo.setTempoAbertoY(Int32.Parse(txtTempoY.Text)*10);
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
            atualizarSemaforo();
            semaforo.atualiza();
            atualizarCarros();
        }

        private void atualizarGraficos()
        {
            Series seriesX = this.chtRuaX.Series[0];
            seriesX.Points.Add(contCarrosX);

            if (seriesX.Points.Count > 30) {
                seriesX.Points.RemoveAt(0);
            }

            Series seriesY = this.chtRuaX.Series[1];
            seriesY.Points.Add(contCarrosY);

            if (seriesY.Points.Count > 30)
            {
              seriesY.Points.RemoveAt(0);
            }
            contCarrosX = 0;
            contCarrosY = 0;
        }


        private void atualizarSemaforo()
        {
            semaforo.setTempoAbertoX(Int32.Parse(txtTempoX.Text)*10);
            semaforo.setTempoAbertoY(Int32.Parse(txtTempoY.Text)*10);
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
                contCarrosX++;
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
                contCarrosX++;
            }
            carroSerDestruido = null;
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
                listaCarrosYe.Remove(carroSerDestruido);
                contCarrosY++;
            }
            carroSerDestruido = null;
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
                listaCarrosYd.Remove(carroSerDestruido);
                contCarrosY++;
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
                        if (listaCarrosXc.Count < new Random().Next(5, 10))
                            listaCarrosXc.Add(carro);
                    }
                    else
                    {
                        if (listaCarrosXb.Count < new Random().Next(5, 10))
                            listaCarrosXb.Add(carro);
                    }
                        
                }
                else
                {
                    if (faixa == 0)
                        if (listaCarrosYe.Count < new Random().Next(5, 10))
                            listaCarrosYe.Add(carro);
                    else
                        if (listaCarrosYd.Count < new Random().Next(5, 10))
                            listaCarrosYd.Add(carro);
                }
            }
        }
        private void tmCarros_Tick(object sender, EventArgs e)
        {
            GerarTrafego("X");
            GerarTrafego("Y");
        }
        private void txtTempoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearDiferenteDigitos(e);
        }
        private void txtTempoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloquearDiferenteDigitos(e);
        }
        private void bloquearDiferenteDigitos(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        private void tmrGrafico_Tick(object sender, EventArgs e)
        {
            atualizarGraficos();
        }
    }
}
