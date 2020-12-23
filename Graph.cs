using System;
using System.Collections.Generic;

namespace Practicks_TMP_2
{
    class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }
            return matrix;
        }

        public List<Vertex> GetVertexLists(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in Edges)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }

        public static void GetMatrix(Graph graph)
        {
            for (int i = 0; i < graph.VertexCount; ++i)
            {
                Console.Write($"  {i + 1}");
            }
            Console.WriteLine();
            int[,] matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write("|" + matrix[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_________________________");
            Console.WriteLine(" ");
        }

        public static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number + ": ");
            foreach (var v in graph.GetVertexLists(vertex))
            {
                Console.Write(v.Number + ", ");
            }
            Console.WriteLine();
        }

        public static void V_V (Graph graph,Vertex vertex)
        {
            foreach (var v in graph.GetVertexLists(vertex))
            {

            }
        }
    }
}
