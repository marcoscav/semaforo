using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetoSemafaro
{
    class Carro
    {
        private static int idGeral;
        private int id;
        private int velocidade;
        private System.Windows.Forms.Control radio;
        private String direcao;
        private Semaforo semaforo;
        private Boolean isFinalizado;
        private Boolean isPassouPeloSemaforo;

        

        public Carro(int velocidadeAtual, String direcaoAtual)
        {
            velocidade = velocidadeAtual;
            direcao = direcaoAtual;
            id = idGeral++;
                isPassouPeloSemaforo = false;
        }

        public void atualizar(){
            if (semaforo != null && !isFinalizou())
            {
                Point p = new Point();
                p.X = radio.Location.X;
                p.Y = radio.Location.Y;

                if (direcao == "X")
                {
                    if (semaforo.getStatusX() == "A")
                    {
                        p.X += velocidade;
                    }
                    else
                    {
                        if (radio.Location.X < 115)
                        {
                            p.X = (p.X + velocidade > 115) ? 115 : p.X + velocidade;
                        }
                        else if (radio.Location.X > 115)
                        {
                            p.X += velocidade;
                            isPassouPeloSemaforo = true;
                        }
                    }

                    if (p.X > 400)
                    {
                        setFinalizou(true);
                        p.X = -30;//Mudar para destroy
                    }
                }
                else if(direcao == "Y")
                {
                    if (semaforo.getStatusY() == "A")
                    {
                        p.Y += velocidade;
                    }
                    else
                    {
                        if (radio.Location.Y < 85)
                        {
                            p.Y = (p.Y + velocidade > 85) ? 85 : p.Y + velocidade;
                        }
                        else if (radio.Location.Y > 85)
                        {
                            p.Y += velocidade;
                            IsPassouPeloSemaforo = true;
                        }
                    }

                    if (p.Y > 400)
                    {
                        p.Y = -30;//Mudar para destroy
                        setFinalizou(true);
                    }
                }
                radio.Location = p;
            }
        }

        public void setRadio(System.Windows.Forms.Control r)
        {
            radio = r;
        }

        public void setVelocidade(int v)
        {
            velocidade = v;
        }

        public void setDirecao(String d)
        {
            direcao = d;
        }

        public void setSemaforo(Semaforo s)
        {
            semaforo = s;
        }

        public System.Windows.Forms.Control getRadio()
        {
            return radio;
        }

        public void destruirRadio()
        {
            radio.Dispose();
            radio.Hide();
        }


        public String ToString(){
            return id.ToString() + " -d:" + direcao + " -v:" + velocidade.ToString();
        }


        public void setFinalizou(Boolean passou)
        {
            this.isFinalizado = passou;
        }

        public Boolean isFinalizou()
        {
            return this.isFinalizado;
        }

        public Boolean IsPassouPeloSemaforo
        {
            get { return isPassouPeloSemaforo; }
            set { isPassouPeloSemaforo = value; }
        }
    }
}
