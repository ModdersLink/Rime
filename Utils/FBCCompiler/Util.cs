using System;
using System.Collections.Generic;

namespace FBCC
{
    static class Util
    {
        public static IEnumerable<List<T>> SplitChunks<T>(this List<T> p_Source, int p_ChunkSize)
        {
            for (var i = 0; i < p_Source.Count; i += p_ChunkSize)
                yield return p_Source.GetRange(i, Math.Min(p_ChunkSize, p_Source.Count - i));

        }

        public static List<T> TSort<T>(this IEnumerable<T> p_Source, Func<T, IEnumerable<T>> p_Dependencies)
        {
            var s_Sorted = new List<T>();
            var s_Visited = new HashSet<T>();

            foreach (var s_Item in p_Source)
                Visit(s_Item, s_Visited, s_Sorted, p_Dependencies);

            return s_Sorted;
        }

        private static void Visit<T>(T p_Item, HashSet<T> p_Visited, List<T> p_Sorted, Func<T, IEnumerable<T>> p_Dependencies)
        {
            if (!p_Visited.Contains(p_Item))
            {
                p_Visited.Add(p_Item);

                foreach (var s_Dep in p_Dependencies(p_Item))
                    Visit(s_Dep, p_Visited, p_Sorted, p_Dependencies);

                p_Sorted.Add(p_Item);
            }
            else
            {
                if (!p_Sorted.Contains(p_Item))
                    throw new Exception($"Circular dependencies are not supported. Please check '${p_Item.ToString()}'.");
            }
        }

        /*public static List<T> TSort<T>(this IEnumerable<T> p_Source, Func<T, HashSet<T>> p_Dependencies)
        {
            // Calculate edges.
            var s_Edges = new HashSet<Tuple<T, T>>();
            var s_Nodes = p_Source.ToList();

            foreach (var s_Item in s_Nodes)
            {
                var s_Dependencies = p_Dependencies(s_Item);

                foreach (var s_Dep in s_Dependencies)
                    s_Edges.Add(Tuple.Create(s_Item, s_Dep));
            }

            // Empty list that will contain the sorted elements
            var L = new List<T>();

            // Set of all nodes with no incoming edges
            var S = new HashSet<T>(s_Nodes.Where(n => s_Edges.All(e => e.Item2.Equals(n) == false)));

            // while S is non-empty do
            while (S.Any())
            {

                //  remove a node n from S
                var n = S.First();
                S.Remove(n);

                // add n to tail of L
                L.Add(n);

                // for each node m with an edge e from n to m do
                foreach (var e in s_Edges.Where(e => e.Item1.Equals(n)).ToList())
                {
                    var m = e.Item2;

                    // remove edge e from the graph
                    s_Edges.Remove(e);

                    // if m has no other incoming edges then
                    if (s_Edges.All(me => me.Item2.Equals(m) == false))
                    {
                        // insert m into S
                        S.Add(m);
                    }
                }
            }

            // if graph has edges then
            if (s_Edges.Any())
            {
                // return error (graph has at least one cycle)
                throw new Exception("Circular dependencies are currently not supported.");
            }

            // return L (a topologically sorted order)
            return L;
        }*/
    }
}
