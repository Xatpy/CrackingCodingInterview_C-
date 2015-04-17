using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview
{
    class Chapter3
    {
    }

    class Stack
    {
        Node top;

        Node pop()
        {
            if (top != null)
            {
                Object item = top.Data;
                top = top.Next;
                return (Node)item;
            }
            return null;
        }

        void push(Object item)
        {
            Node t = new Node((int)item);
            t.Next = top;
            top = t;
        }

        /*Node min()
        {

        }*/
    }
}
