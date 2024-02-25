using ChallengeApp;

Employee employee1 = new Employee("Darek", "Małkowski", 49);
Employee employee2 = new Employee("Agata", "Kowalska", 34);
Employee employee3 = new Employee("Tadeusz", "Wiśniewski", 45);

employee1.AddScore(1); 
employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(4);
employee1.AddScore(6);

employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach(var employee in employees)

{
    
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee; 
    }
};

Console.WriteLine(employeeWithMaxResult.Name+" "
    +employeeWithMaxResult.Surname
    +" wiek: "+employeeWithMaxResult.Age
    +" otrzymał(a) "+maxResult+" punktów.");





