//https://leetcode-cn.com/problems/design-hashmap/

public class MyHashMap {

    private int[] values;

    /** Initialize your data structure here. */
    public MyHashMap() {
        values = new int[1000001];
        for (int i = 0; i < values.Length; i++)
            values[i] = -1;
    }
    
    /** value will always be positive. */
    public void Put(int key, int value) {

        if(value < 0 || value > 1000000 || key < 0 || key > 1000000)
            return; 

        values[key] = value;
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key) {
        if(key < 0 || key > 1000001)
            return -1; 
        return values[key];
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key) {
        if(key < 0 || key > 1000001)
            return; 
        values[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */