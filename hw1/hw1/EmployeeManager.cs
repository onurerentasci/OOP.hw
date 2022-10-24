using hw1;
using System.Security.Cryptography.X509Certificates;

public class EmployeeManager
{
    private List<Employee> _employees;

    public EmployeeManager()
    {
        _employees = new List<Employee>();
    }

    public void Add(Employee employee)
    {
        _employees.Add(employee);
    }

    public void Remove(int id)
    {
        var employee = _employees.FirstOrDefault(x => x.Id == id);
        if (employee != null)
        {
            _employees.Remove(employee);
        }

    }
    public void ListofAll()
    {
        foreach (var item in _employees)
        {
            Console.WriteLine(item);
        }
    }
}

