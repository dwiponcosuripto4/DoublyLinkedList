using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
         * It consists of the information part and links to
         * its succceeding and preceeding nodes
         * in term of next and previeous nodes. */
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }
}
