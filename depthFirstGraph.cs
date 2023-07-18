using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class depthFirstGraph
    {
        private Dictionary<string, List<string>> graph;

        public depthFirstGraph()
        {
            graph = new Dictionary<string, List<string>>();
        }
        
        public void AddVertex(string vertex)
        {
            if (!graph.ContainsKey(vertex))
            {
                graph[vertex] = new List<string>();
            }
        }

        public void AddEdge(string source, string destination)
        {
            if (!graph.ContainsKey(source))
            {
                AddVertex(source);
            }

            if (!graph.ContainsKey(destination))
            {
                AddVertex(destination);
            }

            graph[source].Add(destination);
        }

        public void DFS(string startVertex)
        {
            HashSet<string> visited = new HashSet<string>();
            DFSHelper(startVertex, visited);
        }

        private void DFSHelper(string vertex, HashSet<string> visited)
        {
            visited.Add(vertex);
            Console.Write(vertex + " ");

            if (graph.ContainsKey(vertex))
            {
                foreach (string neighbor in graph[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        DFSHelper(neighbor, visited);
                    }
                }
            }
        }
    }
}
