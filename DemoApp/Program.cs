using DemoApp.framework;

var db = new ShopDbContext();

if(args.Length == 0)
{
    foreach(var department in db.Departments)
        Console.WriteLine("{0, -6}{1, 12:0.00}{2, 8}", department.Id, department.DeptName, department.DeptLoct);
}
else
{
    int pno = int.Parse(args[0]);
    var department = db.Departments
                .Where(p => p.Id == pno)
                .Include(p => p.Employees)
                .FirstOrDefault();
    if(department != null)
    {
        foreach(var employee in department.Employees)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", employee.Id, employee.EmpName, employee.Salary, employee.EmpAge, employee.DepartmentId);
    }
}
