using System;

namespace Xadrez_Console.Tabuleiro.Exceptions
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
