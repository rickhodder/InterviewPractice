using ReverseLinkList;
using Xunit;

namespace ReverseLinkedList.Tests
{
    public class NodeReverserTests
    {
        private readonly NodeReverser _sut;

        public NodeReverserTests()
        {
            _sut = new NodeReverser();
        }

        [Fact]
        public void ReverseOneNodeSucceeds()
        {
            var actual = _sut.Reverse(BuildList(1));
            
            Assert.Equal(0,actual.Value);
            Assert.Null(actual.Next);
        }

        [Fact]
        public void ReverseTwoNodesSucceeds()
        {
            var actual = _sut.Reverse(BuildList(2));

            Assert.Equal(1, actual.Value);
            Assert.Equal(0, actual.Next.Value);
            Assert.Null(actual.Next.Next);

        }

        [Fact]
        public void ReverseThreeNodesSucceeds()
        {
            var actual = _sut.Reverse(BuildList(3));

            Assert.Equal(2, actual.Value);
            Assert.Equal(1, actual.Next.Value);
            Assert.Equal(0, actual.Next.Next.Value);
            Assert.Null(actual.Next.Next.Next);
        }

        /// <summary>
        /// Build a linked list of itemCount nodes, with values starting with 0 and increasing by 1 
        /// </summary>
        /// <param name="itemCount">Number of nodes in the list</param>
        /// <returns></returns>
        private Node BuildList(int itemCount)
        {
            var head = new Node { Value = 0 };

            if (itemCount==1)
            {
                return head;
            }
            var current = head;

            for (int i = 0; i < itemCount-1; i++)
            {
                var next = new Node { Value = i + 1 };
                current.Next = next;
                current = next;
            }

            return head;
        }
    }
    
}
