//https://leetcode-cn.com/problems/keys-and-rooms/description/

using System.Collections.Generic;

public class KeysandRoomsDemo {
    private SortedSet<int> m_setKeys = new SortedSet<int>();

    public bool CanVisitAllRooms(IList<IList<int>> rooms) {

        IList<int> oriKeys = rooms[0];
        m_setKeys.Add(0);
        VisitRooms(rooms, oriKeys);

        return m_setKeys.Count == rooms.Count;
    }

    private void VisitRooms(IList<IList<int>> rooms, IList<int> keys)
    {
        foreach (int key in keys)
        {
            if (m_setKeys.Contains(key))
                continue;

            m_setKeys.Add(key);
            VisitRooms(rooms, rooms[key]);
        }
    }
}