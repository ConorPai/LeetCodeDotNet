//https://leetcode-cn.com/problems/construct-quad-tree/description/

public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node(){}
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}

public class ConstructQuadTreeDemo {
    public Node Construct(int[][] grid) {
        return Construct(grid, 0, 0, grid.Length);
    }

    private Node Construct(int[][] grid, int x, int y, int length) {
        if (length == 1)
        {
            return new Node(grid[x][y] == 1, true, null, null, null, null);
        }

        Node topLeft = Construct(grid, x, y, length / 2);
        Node topRight = Construct(grid, x, y + length / 2, length / 2);
        Node bottomLeft = Construct(grid, x + length / 2, y, length / 2);
        Node bottomRight = Construct(grid, x + length / 2, y + length / 2, length / 2); 

        if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf
        && topLeft.val == topRight.val && topRight.val == bottomLeft.val && bottomLeft.val == bottomRight.val)
        {
            return new Node(grid[x][y] == 1, true, null, null, null, null);
        }
        else
        {
            return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
        }
    }
}