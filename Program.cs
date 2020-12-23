using System;

namespace Practicks_TMP_2
{
    class Program:Graph
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            var v1 = new Vertex(1); graph.AddVertex(v1);
            
            var v2 = new Vertex(2); graph.AddVertex(v2);
            
            var v3 = new Vertex(3); graph.AddVertex(v3);
            
            var v4 = new Vertex(4); graph.AddVertex(v4);
            
            var v5 = new Vertex(5); graph.AddVertex(v5);

            var v6 = new Vertex(6); graph.AddVertex(v6);

            var v7 = new Vertex(7); graph.AddVertex(v7);

            var v8 = new Vertex(8); graph.AddVertex(v8);

            graph.AddEdge(v1, v2); 
            graph.AddEdge(v1, v4);
            graph.AddEdge(v2, v3);
            graph.AddEdge(v3, v5);
            graph.AddEdge(v3, v7);
            graph.AddEdge(v4, v2);
            graph.AddEdge(v4, v3);
            graph.AddEdge(v5, v1);
            graph.AddEdge(v5, v4);
            graph.AddEdge(v6, v2);
            graph.AddEdge(v6, v8);
            graph.AddEdge(v7, v6);
            graph.AddEdge(v7, v8);
            graph.AddEdge(v8, v2);
            graph.AddEdge(v8, v3);

            GetMatrix(graph);

            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            GetVertex(graph, v5);
            GetVertex(graph, v6);
            GetVertex(graph, v7);
            GetVertex(graph, v8);
        }
    }
}
