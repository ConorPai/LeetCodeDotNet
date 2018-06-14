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
        
        Dictionary<int, Employee> empDicts = new Dictionary<int, Employee>();
        foreach (Employee e in employees)
            empDicts[e.id] = e;

        return getImportance(empDicts, id);
    }

    private int getImportance(Dictionary<int, Employee> empDicts, int nRoot)
    {
        if (!empDicts.ContainsKey(nRoot))
            return 0;
        
        int nTotalImportance = empDicts[nRoot].importance;

        if (empDicts[nRoot].subordinates == null)
            return nTotalImportance;

        foreach(int nID in empDicts[nRoot].subordinates)
            nTotalImportance += getImportance(empDicts, nID);

        return nTotalImportance;
    }
};