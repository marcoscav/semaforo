using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSemafaro
{
    class Semaforo
    {
        private String statusX = "F";
        private String statusY = "A";
        private String statusAnterior = "X";
        private bool isFechados = false;
        private int tempoAbertoX;
        private int tempoAbertoY;
        private int tempoAtual = 0;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox imagemSemaforoX;
        private System.Windows.Forms.PictureBox imagemSemaforoY;

        public void atualiza() {
            if (tempoAtual <= 0)
            {
                if (statusX == "A")
                {
                    tempoAtual = 30;
                    statusX = "F";
                    statusAnterior = "X";
                    imagemSemaforoX.Image = new Bitmap(ProjetoSemafaro.Properties.Resources.semaforo_vermelho);
                }
                else if (statusY == "A")
                {
                    statusY = "F";
                    tempoAtual = 30;
                    statusAnterior = "Y";
                    imagemSemaforoY.Image = new Bitmap(ProjetoSemafaro.Properties.Resources.semaforo_vermelho);
                }
                else
                {
                    if (statusAnterior == "X")
                    {
                        statusY = "A";
                        tempoAtual = tempoAbertoY;
                        imagemSemaforoY.Image = new Bitmap(ProjetoSemafaro.Properties.Resources.semaforo_verde);
                    }
                    else
                    {
                        statusX = "A";
                        tempoAtual = tempoAbertoX;
                        imagemSemaforoX.Image = new Bitmap(ProjetoSemafaro.Properties.Resources.semaforo_verde);
                    }
                        
                }
            }
            label.Text = tempoAtual/10 +" |X-> " + statusX + "  Y -> " + statusY;
            tempoAtual--;
        }

        //public void setStatusX(String s) {statusX = s;}
        //public void setStatusY(String s){statusY = s;}

        public String getStatusX() { return statusX; }
        public String getStatusY() { return statusY; }

        public void setTempoAbertoX(int t){tempoAbertoX = t;}
        public void setTempoAbertoY(int t){tempoAbertoY = t;}

        public int getTempoAbertoX() { return tempoAbertoX; }
        public int getTempoAbertoY() { return tempoAbertoY; }

        public void setLabel(System.Windows.Forms.Label l)
        {
            label = l;
        }

        public System.Windows.Forms.PictureBox ImagemSemaforoX
        {
            get { return imagemSemaforoX; }
            set { imagemSemaforoX = value; }
        }

        public System.Windows.Forms.PictureBox ImagemSemaforoY
        {
            get { return imagemSemaforoY; }
            set { imagemSemaforoY = value; }
        }
    }
}
