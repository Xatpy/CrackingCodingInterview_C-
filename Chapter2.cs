using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingCodingInterview
{
    /***
     * CHAPTER 2 : Linked lists
     ***/
    class Chapter2
    {     
      
        public void RemoveDuplicates(ref Node list)
        {
            List<int> listRepeated = new List<int>();
            Node lastNode = null;
            Node aux = list;
            Node origin = list;
            while (aux.Next != null)
            {
                lastNode = aux; //Auxiliar, in case we have to delete it.

                //Check if we have the data in our listAux
                bool deleted = false;
                foreach (int dt in listRepeated)
                {
                    if (dt == aux.Data)
                    {
                        //Remove this element
                        lastNode.Next = aux.Next;
                        deleted = true;
                        break;
                    }
                }

                if (!deleted)
                {
                    listRepeated.Add(aux.Data);
                }
                
                aux = aux.Next;
            }//Check final node                        
        }
    }

    public class Node
    {
        Node next = null;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        int data;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node(int d) { data = d; }

        public void appendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null) { n = n.next; }
            n.next = end;
        }
    }
}
