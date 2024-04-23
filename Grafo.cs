using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeAdjacencia
{
    public class Grafo
    {
        private List<List<int>> vertices;
        private bool startsAtOne;
        public Grafo(bool _startsAtOne = false)
        {
            startsAtOne = _startsAtOne;
            vertices = new List<List<int>>();
        }

        public List<List<int>> getVertices()
        {
            return vertices;
        }

        public void AdicionarVertice()
        {
            List<int> vertice = new List<int>();
            vertice.Add(vertices.Count);
            vertices.Add(vertice);
        }

        public void AdicionarAresta(int origem, int destino)
        {

            if (vertices.Count < origem || vertices.Count < destino)
            {
                throw new Exception("Vertice não existe.");
            }

            if (startsAtOne)
            {
                origem--;
                destino--;
            }
            vertices[origem].Add(destino);
        }

        public void MostraLista()
        {
            Console.WriteLine("\nLista de adjacencia:");
            for (int i = 0; i < vertices.Count; i++)
            {
                if (startsAtOne)
                {
                    Console.Write($"Vertice {i + 1}: ");
                }
                else
                {
                    Console.Write($"Vertice {i}: ");
                }
                for (int j = 0; j < vertices[i].Count; j++)
                {
                    if (startsAtOne)
                    {
                        Console.Write($"{vertices[i][j] + 1} ");
                    }
                    else
                    {
                        Console.Write($"{vertices[i][j]} ");
                    }

                }
                Console.WriteLine();
            }
        }

        public void BFSSearch(int verticeInicial = 0)
        {
            Queue<int> fila = new Queue<int>();
            List<int> visitados = new List<int>();

            fila.Enqueue(vertices[verticeInicial][0]);
            while (fila.Count > 0)
            {
                int current = fila.Dequeue();
                foreach (int vertice in vertices[current])
                {
                    if (!visitados.Contains(vertice))
                    {
                        fila.Enqueue(vertice);
                        visitados.Add(vertice);
                    }
                }
            }

            Console.WriteLine("\nBFS:");
            PrintVisitados(visitados);
        }

        public void DFSRecursive(int verticeInicial = 0)
        {
            Stack<int> pilha = new Stack<int>();
            List<int> visitados = new List<int>();

            pilha.Push(vertices[verticeInicial][0]);

            DFSUtil(vertices[verticeInicial][0], visitados);

            Console.WriteLine("\nDFS Recursivo:");
            PrintVisitados(visitados);

            void DFSUtil(int vertice, List<int> visitados)
            {
                visitados.Add(vertice);
                foreach (int i in vertices[vertice])
                {
                    if (!visitados.Contains(i))
                    {
                        DFSUtil(i, visitados);
                    }
                }
            }
        }


        public void DFSIterative(int verticeInicial = 0)
        {
            List<List<int>> grafoCopy = vertices;
            Stack<int> pilha = new Stack<int>();
            List<int> visitados = new List<int>();

            pilha.Push(grafoCopy[verticeInicial][0]);
            while (pilha.Count > 0)
            {
                int current = pilha.Pop();
                if (!visitados.Contains(current))
                {
                    visitados.Add(current);

                    for (int vertice = grafoCopy[current].Count - 1; vertice >= 1; vertice--)
                    {
                        if (!visitados.Contains(grafoCopy[current][vertice]))
                        {
                            pilha.Push(grafoCopy[current][vertice]);
                        }
                    }

                }
            }
            Console.WriteLine("\nDFS Iterativo:");
            PrintVisitados(visitados);
        }

        public void PrintVisitados(List<int> visitados)
        {
            if (startsAtOne)
            {
                for (int i = 0; i < visitados.Count; i++)
                {
                    visitados[i]++;
                }
            }
            Console.WriteLine($"{String.Join(", ", visitados.ToArray())}");
        }

    }
}