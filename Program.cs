namespace AISD_CS
{
    class Program
    {
        private static void Main(string[] args)
        {
            GraphList graphList = new GraphList(5);

            graphList.addEdge(0, 2);
            graphList.addEdge(2, 3);
            graphList.addEdge(3, 4);
            graphList.addEdge(4, 1);
            graphList.addEdge(1, 0);
            graphList.addEdge(2, 1);
            graphList.addEdge(3, 1);
            graphList.addEdge(3, 2);

            graphList.print();

            graphList.DFS(1);
            graphList.BFS(1);
        }
    }
}
