public class EmployeeData{

    private List <Employee> employees;
    private VacationTimeData vacationTimeData;


    public EmployeeData(VacationTimeData vacationTimeData){
        this.vacationTimeData = vacationTimeData;
        employees = new List <Employee>{
            new Employee("001", "Stefan Hettgen", "1335 Montclair Drive", "hettgen49@gmail.com", "(289)834-9902", "Software Engineer"),
        new Employee("002", "George Hotz", "1050 Falgarwood Drive", "ghotz@gmail.com", "(918)443-2135", "Software Engineer"),
        new Employee("003", "Gregory Smith", "987 Parklane Drive", "GregSmith@gmail.com", "(709)727-9505", "Team Lead"),
        new Employee("004", "David Grayson", "1250 Beaumont Avenue", "grayson@gmail.com", "(604)797-6620", "System Administrator"),
        new Employee("005", "Adam Lucas", "670 Princess Anne Crescent", "aLucas@gmail.com", "(306)393-5294", "Manager")
        };

        foreach (var employee in employees){
            vacationTimeData.AddVacationTime(new VacationTime(employee.id, employee.id, 14));
        }
    }

    public List<Employee> GetAllEmployees(){
            return employees;
    }

    public bool AddEmployee(Employee employee){
        if(employees.Any(e => e.id == employee.id)){
            return false;
        }
        employees.Add(employee);
        vacationTimeData.AddVacationTime(new VacationTime(employee.id, employee.id, 14));
        return true;
    }

    public Employee getEmployeeById(string id){
        return employees.SingleOrDefault(e => e.id == id);
    }

    public void UpdateEmployee(Employee employee){
        
        try{
            var existingEmployee = employees.SingleOrDefault(e => e.id == employee.id);
            if (existingEmployee != null){
                existingEmployee.name = employee.name;
                existingEmployee.address = employee.address;
                existingEmployee.email = employee.email;
                existingEmployee.phone = employee.phone;
                existingEmployee.role = employee.role;
            }
        }
        catch (InvalidOperationException){
            
        }
    }

    public void DeleteEmployee(string id){
        var employee = employees.SingleOrDefault(e => e.id == id);
        if (employee != null)
            {
                employees.Remove(employee);
                vacationTimeData.DeleteVacationTime(id);
            }
    }

    public void DisplayAllEmployees(){
        Console.Clear();
        
        foreach(Employee employee in employees){
            Console.WriteLine($"ID: {employee.id}, Name: {employee.name}, Address: {employee.address}, Email: {employee.email}, Phone: {employee.phone}, Role: {employee.role}");
            
        }

    }
    public bool UniqueId(string id){
        
        var employee = employees.SingleOrDefault(e => e.id == id);

        return employee == null;

    }

}