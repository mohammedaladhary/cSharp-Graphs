namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graphs");

            mrGraph mrGraph = new mrGraph();
            mrGraph.AddVertex("1");
            mrGraph.AddVertex("2");
            mrGraph.AddVertex("3");
            mrGraph.AddVertex("4");

            mrGraph.AddEdge("1", "2");
            mrGraph.AddEdge("2", "3");
            mrGraph.AddEdge("3", "4");
            mrGraph.AddEdge("4", "1");

            //displaying the neighbours
            Dictionary<string,List<string>> keys = mrGraph.PrintGraph();
            foreach(var vertex in keys)
            {
                Console.WriteLine("vertex: "+ vertex.Key);
                Console.WriteLine("Neighbours: "+ string.Join(", ",vertex.Value));
            }
        }
    }
}