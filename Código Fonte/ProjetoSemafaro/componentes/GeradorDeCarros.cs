using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSemafaro.componentes
{
    class GeradorDeCarros
    {

        public static Carro gerarCarro(int velocidade, String direcao, Semaforo semaforo, int faixa)
        {
            Carro carro = new Carro(velocidade, direcao);
            Point p = new Point();
            System.Windows.Forms.Button newCar = new System.Windows.Forms.Button();
            if (direcao == "X")
            {
                p.X = -50;
                p.Y = (faixa == 0) ? 128 : 147;
                newCar.Height = 16;
                newCar.Width = 32;
                
            }
            else
            {
                p.X = (faixa == 0) ? 154 : 172;
                p.Y = -50;
                newCar.Height = 32;
                newCar.Width = 16;
            }
            newCar.Text = "";
            newCar.Location = p;
            carro.setRadio(newCar);
            carro.setSemaforo(semaforo);
            return carro;
        }
    }
}
