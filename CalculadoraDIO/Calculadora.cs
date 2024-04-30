using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDIO
{
    public class Calculadora
    {
        private Queue<string> historico;
        public Calculadora() 
        { 
            this.historico = new Queue<string>();
        }

        private void AtualizaHistorico(string informacao)
        {
            string dataHoje = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            if (historico.Count() > 2)
            {
                historico.Dequeue();
                historico.Enqueue(informacao + dataHoje);
            }
            else
                historico.Enqueue(informacao + dataHoje);
        }

        public int Soma(int x, int y)
        {
            int soma = x + y;
            AtualizaHistorico($"Soma: {x} + {y} = {soma}");

            return soma;
        }

        public int Subtracao(int x, int y)
        {
            int sub = x - y;
            AtualizaHistorico($"Subtracao: {x} - {y} = {sub}");

            return sub;
        }

        public int Divisao(int x, int y)
        {
            int quociente = x / y;
            AtualizaHistorico($"Divisao: {x} / {y} = {quociente}");
            
            return quociente;
        }

        public int Multiplicacao(int x, int y)
        {
            int produto = x * y;
            AtualizaHistorico($"Multiplicacao: {x} * {y} = {produto}");

            return produto;
        }

        public Queue<string> Historico()
        {
            return historico;
        }
    }
}
