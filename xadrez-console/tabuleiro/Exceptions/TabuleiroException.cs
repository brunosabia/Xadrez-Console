using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro.Exceptions
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg): base(msg)
        {

        }
    }
}
