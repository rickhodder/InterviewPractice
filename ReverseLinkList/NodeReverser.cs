namespace ReverseLinkList
{
    public class NodeReverser
    {
        public Node Reverse(Node node)
        {
            // if only one item in list, return it
            if (node.Next is null)
            {
                return node;
            }

            // Swap current item and next item in the list recursively
            var result = Swap(node, node.Next);

            node.Next = null;

            return result;
        }


        public Node Swap(Node current, Node next)
        {
            // if reached the end of the list, return the last item
            if (next is null)
            {
                return current;
            }

            // recursively swap 
            var result = Swap(next, next.Next);

            // on the way back out, reverse the Next pointer 
            next.Next = current;

            return result;
        }
    }
}
