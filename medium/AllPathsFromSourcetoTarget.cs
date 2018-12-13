//https://leetcode-cn.com/problems/all-paths-from-source-to-target/

using System.Collections.Generic;

public class AllPathsFromSourcetoTargetDemo {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        IList<IList<int>> ret = new List<IList<int>>();
        GetPath(graph, ret, new List<int>(), 0);
        return ret;
    }

    private void GetPath(int[][] graph, IList<IList<int>> res, IList<int> path, int position)
    {
        path.Add(position);
        if (position == graph.GetLength(0) - 1)
            res.Add(path);

        for (int i = 0; i < graph[position].Length; i++)
        {
            List<int> pathClone = new List<int>(path);
            GetPath(graph, res, pathClone, graph[position][i]);
        }
    }
}