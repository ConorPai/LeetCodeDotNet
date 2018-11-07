//https://leetcode-cn.com/problems/design-hashset/

public class MyHashSet {

    private bool[] m_blValues = new bool[1000001];

    /** Initialize your data structure here. */
    public MyHashSet() {
        
    }
    
    public void Add(int key) {
        if (key < 0 || key > 1000001)
            return;

        m_blValues[key] = true;
    }
    
    public void Remove(int key) {
        if (key < 0 || key > 1000001)
            return;

        m_blValues[key] = false;
        
    }
    
    /** Returns true if this set did not already contain the specified element */
    public bool Contains(int key) {
        
        if (key < 0 || key > 1000001)
            return false;

        return m_blValues[key];
    }
}