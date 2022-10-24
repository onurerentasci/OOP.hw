using hw1;

var employee1 = new Employee()
{
    Id = 0,
    FirstName = "Onur",
    LastName = "Taşcı",
    Salary = 12000
};
var employee2 = new Employee()
{
    Id=1,
    FirstName = "Ali",
    LastName = "Yılmaz",
    Salary = 9500
};

var manager = new EmployeeManager();
manager.Add(employee1);
manager.Add(employee2);
manager.Remove(0);
manager.ListofAll();
