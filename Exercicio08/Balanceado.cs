using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Balanceado
    {
        public static bool VerificaBalanceado(string entrada)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char i in entrada)
            {
                if (i == '(')
                {
                    pilha.Push(i);
                }
                else if (i == ')')
                {
                    if (pilha.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        pilha.Pop();
                    }
                }
            }
            
            return pilha.Count == 0;
        }
    }
}