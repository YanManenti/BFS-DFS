using ListaDeAdjacencia;

Grafo grafo1 = new Grafo(_startsAtOne: false);

grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();
grafo1.AdicionarVertice();

grafo1.AdicionarAresta(0, 1);
grafo1.AdicionarAresta(0, 6);
grafo1.AdicionarAresta(0, 8);
grafo1.AdicionarAresta(1, 0);
grafo1.AdicionarAresta(1, 4);
grafo1.AdicionarAresta(1, 9);
grafo1.AdicionarAresta(2, 4);
grafo1.AdicionarAresta(2, 6);
grafo1.AdicionarAresta(3, 4);
grafo1.AdicionarAresta(3, 5);
grafo1.AdicionarAresta(3, 8);
grafo1.AdicionarAresta(4, 1);
grafo1.AdicionarAresta(4, 2);
grafo1.AdicionarAresta(4, 3);
grafo1.AdicionarAresta(4, 5);
grafo1.AdicionarAresta(4, 9);
grafo1.AdicionarAresta(5, 3);
grafo1.AdicionarAresta(5, 4);
grafo1.AdicionarAresta(6, 0);
grafo1.AdicionarAresta(6, 2);
grafo1.AdicionarAresta(7, 9);
grafo1.AdicionarAresta(7, 8);
grafo1.AdicionarAresta(8, 0);
grafo1.AdicionarAresta(8, 3);
grafo1.AdicionarAresta(8, 7);
grafo1.AdicionarAresta(9, 1);
grafo1.AdicionarAresta(9, 4);
grafo1.AdicionarAresta(9, 7);

Console.WriteLine("\nGrafo 1:");

grafo1.MostraLista();

grafo1.BFSSearch(0);
grafo1.DFSRecursive(0);
grafo1.DFSIterative(0);

Grafo grafo2 = new Grafo(_startsAtOne: true);

grafo2.AdicionarVertice();
grafo2.AdicionarVertice();
grafo2.AdicionarVertice();
grafo2.AdicionarVertice();
grafo2.AdicionarVertice();
grafo2.AdicionarVertice();
grafo2.AdicionarVertice();
grafo2.AdicionarVertice();

grafo2.AdicionarAresta(1, 2);
grafo2.AdicionarAresta(1, 3);
grafo2.AdicionarAresta(2, 1);
grafo2.AdicionarAresta(2, 4);
grafo2.AdicionarAresta(2, 5);
grafo2.AdicionarAresta(3, 1);
grafo2.AdicionarAresta(3, 6);
grafo2.AdicionarAresta(3, 7);
grafo2.AdicionarAresta(4, 2);
grafo2.AdicionarAresta(4, 8);
grafo2.AdicionarAresta(5, 2);
grafo2.AdicionarAresta(5, 8);
grafo2.AdicionarAresta(6, 3);
grafo2.AdicionarAresta(6, 8);
grafo2.AdicionarAresta(7, 3);
grafo2.AdicionarAresta(7, 8);
grafo2.AdicionarAresta(8, 4);
grafo2.AdicionarAresta(8, 5);
grafo2.AdicionarAresta(8, 6);
grafo2.AdicionarAresta(8, 7);

Console.WriteLine("\nGrafo 2:");

grafo2.MostraLista();

grafo2.BFSSearch(0);
grafo2.DFSRecursive(0);
grafo2.DFSIterative(0);