using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AISD_CS
{
    internal class GraphList
    {
        int vCount;
        int eCount;

        List<int>[] graphList;

        public GraphList(int vcount) {
            
            this.vCount = vcount;
            this.graphList = new List<int>[vcount];

            for (int i = 0; i < vCount; i++)
            {
                graphList[i] = new List<int>();
            }
        }

        public void addEdge(int start, int end)
        {
            graphList[start].Add(end);
            graphList[end].Add(start);
            eCount++;
        }

        public void print()
        {
            for (int i = 0; i < graphList.Length; i++)
            {
                Console.Write(i.ToString() + ": ");
                for (int j = 0;j < graphList[i].Count; j++)
                {
                    Console.Write(graphList[i][j].ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        public void DFS(int v)
        {
            int[] visited = new int[vCount];
            DFSutil(v, visited);

            foreach (var item in visited)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();

        }

        public void DFSutil(int v, int[] visited)
        {
            visited[v] = 1;
            foreach (int to in graphList[v])
            {
                if (visited[to] == 0)
                    DFSutil(to, visited);
            }
        }

        public void BFS(int v)
        {
            bool[] visited = new bool[vCount];

            Queue<int> q = new Queue<int>();

            q.Enqueue(v);

            while(q.Count > 0)
            {
                int now = q.Dequeue();
                visited[now] = true;
                foreach (int vert in graphList[v])
                {
                    if (!visited[vert])
                        q.Enqueue(vert);
                }
            }

            foreach (var item in visited)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
