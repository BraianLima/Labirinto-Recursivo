using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace LabirintoRecursivo
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        private bool AndaLab(int[,] AndaMat, int I, int J,
            int SadL, int SadC)
        {
            /*
              O ideal seria chamar um método para mostrar na tela,
              porém por escolha mesmo, foi utilizado dessa maneira.
            */  
            if ((I == (SadL - 2)) && (J == (SadC - 4)))
            {
                richtxtLabirinto.Text = string.Empty;
                for (I = 0; I < SadL; I++)
                {
                    for (J = 0; J < SadC - 2; J++)
                    {
                        string S = null;
                        S = Convert.ToString(AndaMat[I, J]);
                        switch (S)
                        {
                            case "0":
                                S = " ";
                                break;
                            case "1":
                                S = "█";
                                break;
                            case "2":
                                S = "$";
                                break;
                            case "3":
                                S = " ";
                                break;
                            default:
                                S = " ";
                                break;
                        }

                        if (I == 1 && J == 1) S = "@";
                        if (I == (SadL - 2) && J == (SadC - 4)) S = "@";
                        richtxtLabirinto.Text = richtxtLabirinto.Text +
                            Convert.ToString(S);
                    }
                    richtxtLabirinto.Text = richtxtLabirinto.Text + "\r\n";
                }
                return true;
            }

            //abaixo, anda para frente no lab...
            else if (AndaMat[I, J + 1] == 0)
            {
                J++;
                AndaMat[I, J] = 2;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            else if (AndaMat[I + 1, J] == 0)
            {
                I++;
                AndaMat[I, J] = 2;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            else if (AndaMat[I - 1, J] == 0)
            {
                I--;
                AndaMat[I, J] = 2;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            else if (AndaMat[I, J - 1] == 0)
            {
                J--;
                AndaMat[I, J] = 2;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            //abaixo, voltando...
            else if (AndaMat[I, J - 1] == 2) //volta da direita indo p/ esquerda
            {
                J--;
                AndaMat[I, J] = 2;
                AndaMat[I, J + 1] = 3;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            else if (AndaMat[I - 1, J] == 2) //volta de baixo indo p/ cima
            {
                I--;
                AndaMat[I, J] = 2;
                AndaMat[I + 1, J] = 3;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            else if (AndaMat[I + 1, J] == 2) //volta de cima indo p/ baixo
            {
                I++;
                AndaMat[I, J] = 2;
                AndaMat[I - 1, J] = 3;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }

            else if (AndaMat[I, J + 1] == 2) //volta da esquerda indo p/ direita
            {
                J++;
                AndaMat[I, J] = 2;
                AndaMat[I, J - 1] = 3;
                return AndaLab(AndaMat, I, J, SadL, SadC);
            }
            return false;
        }

        private void PercorreLabirinto(int[,] Matriz, int IndI,
            int IndJ, int SaidaL, int SaidaC)
        {
            bool Perc = AndaLab(Matriz, IndI, IndJ,
                            SaidaL, SaidaC);
            /*
             Todos os labirintos (que foram gerados randomicamente 
             por outro programa (esse outro programa eu não tenho a permissão
             para compartilhá-lo)), logo, todos os labirinto têm saída,
             ou seja, todos entrarão na condição Perc == true
             */ 
            if (Perc == true) MessageBox.Show("Você saiu do labirinto", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("O labirinto não tem saida", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void abrirLabirintoToolStripMenuItem_Click(object sender,
            EventArgs e)
        {
            Labirint Labirinto = new Labirint();
            richtxtLabirinto.Text = string.Empty;

            int I = Labirinto.Mt3, J = Labirinto.Mt2;
            char[,] ArrChar = new char[I, J];
            int[,] MatrizInteira = new int[I, J];

            //abaixo é "passado" a o labirinto de uma string para matriz
            using (StringReader LendoStr = new StringReader(Labirinto.CarregaArq))
            {
                for (I = 0; I < Labirinto.Mt3; I++)
                {
                    for (J = 0; J < Labirinto.Mt2; J++)
                    {
                        if (Labirinto.TamanhoContador < Labirinto.TamanhoTotal)
                        {
                            ArrChar[I, J] = Labirinto.CarregaArq[Labirinto.TamanhoContador];
                            Labirinto.TamanhoContador++;
                        }

                        switch (ArrChar[I, J])
                        {
                            case ' ':
                                ArrChar[I, J] = '0';
                                break;
                            default:
                                ArrChar[I, J] = '1';
                                break;
                        }
                        MatrizInteira[I, J] =
                            (int)char.GetNumericValue(ArrChar[I, J]);
                    }
                }
            }
            /* Acima: Foi passado para uma matriz do tipo int,
              por escolha da equipe, entretanto é possível trabalhar com char.
              Abaixo: os índices são igualados a 1 pois será trabalhado apenas com os
              caminhos do labirinto e não com as paredes do labirinto
            */

            I = 1;
            J = 1;
            int SaidaL = Labirinto.Mt3, SaidaC = Labirinto.Mt2;
            PercorreLabirinto(MatrizInteira, I, J,
                 SaidaL, SaidaC);
        }

        private void criadoresDoTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Braian Freitas de Lima" + "\r\n\r\n" +
                "Guilherme Lopuch Nogueira" + "\r\n\r\n" +
                "Matheus Henrique de Souza", "Criadores!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
