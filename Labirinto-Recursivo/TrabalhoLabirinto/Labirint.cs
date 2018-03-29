using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirintoRecursivo
{
    class Labirint
    {
        public string CarregaArq { get; set; }
        public string[] Mt { get; set; }
        public int Mt2 { get; set; }
        public int Mt3 { get; set; }
        public int TamanhoTotal { get; set; }
        public int TamanhoContador { get; set; }

        public Labirint()
        {
            CarregaArq = AbreArq();
            TamanhoTotal = CarregaArq.Length;
            Mt = CarregaArq.Split('\n');
            Mt3 = TamanhoIndiceI();
            Mt2 = TamanhoIndiceJ();
        }

        private string AbreArq()
        {
            OpenFileDialog Abre = new OpenFileDialog();
            Abre.ShowDialog();
            StreamReader Leitura = new StreamReader(Abre.FileName);
            CarregaArq = Leitura.ReadToEnd();
            return CarregaArq;
        }

        private int TamanhoIndiceI()
        {
            Mt3 = Mt.Count();
            Mt3--; 
            return Mt3; //linhas da matriz
        }

        private int TamanhoIndiceJ()
        {
            Mt2 = Mt[0].Length;
            Mt2 += 1;
            return Mt2; //colunas da matriz
        }

    }
}
