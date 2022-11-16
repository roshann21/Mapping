namespace DemoApp.framework;

public class Department
{

    public int Id { get; set; }

    public string DeptName { get; set; }

    public string DeptLoct { get; set; }

    //navigation property
    public List<Employee> Employees { get; set; }
}