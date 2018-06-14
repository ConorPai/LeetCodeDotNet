//https://leetcode-cn.com/problems/employee-importance/description/
// Employee info
using System.Collections.Generic;

public class Employee {

    public Employee(int nID, int nImportance, List<int> listSubordinates)
    {
        id = nID;
        importance = nImportance;
        subordinates = listSubordinates;
    }

    // It's the unique ID of each node.
    // unique id of this employee
    public int id;
    // the importance value of this employee
    public int importance;
    // the id of direct subordinates
    public List<int> subordinates;
};

public class EmployeeImportanceDemo {
    public int getImportance(List<Employee> employees, int id) {
        
        Employee eRoot = null;
        Dictionary<int, Employee> empDicts = new Dictionary<int, Employee>();
        foreach (Employee e in employees)
        {
            empDicts[e.id] = e;
            if (e.id == id)
                eRoot = e;
        }

        if (eRoot == null)
            return 0;

        return getImportance(empDicts, eRoot);
    }

    private int getImportance(Dictionary<int, Employee> empDicts, Employee eRoot)
    {
        if (eRoot == null)
            return 0;
        
        int nTotalImportance = eRoot.importance;

        if (eRoot.subordinates == null)
            return nTotalImportance;

        foreach(int nID in eRoot.subordinates)
            nTotalImportance += getImportance(empDicts, empDicts[nID]);

        return nTotalImportance;
    }
};