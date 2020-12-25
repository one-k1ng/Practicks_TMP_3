using System;

namespace Practicks_TMP_2
{
    class Program:Graph
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.PushNode(1);
            graph.PushNode(2);
            graph.PushNode(3);
            graph.PushNode(4);
            graph.PushNode(5);

            graph.ConnectNodes(1, 2);
            graph.ConnectNodes(2, 3);
            graph.ConnectNodes(3, 1);
            graph.ConnectNodes(4, 5);
            graph.ConnectNodes(5, 4);

            graph.PrintMatrix();
        }
    }
}
