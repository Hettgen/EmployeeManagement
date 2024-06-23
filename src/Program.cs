class Program{

    

    static void Main(){

        var vacationData = new VacationTimeData();
        var employeeData = new EmployeeData(vacationData);

    bool isRequestedExit = false;

    do{
        // nextMenu is for navigating the menu heirarchy, requested action is for performing actions on data
        int nextMenu = -1;
        int requestedAction = -1;

        nextMenu = Menus.MainMenu();

        // Modify Employees
        if(nextMenu == 0){
            while(true){
                requestedAction = Menus.EmployeeMenu();
                if(requestedAction == 4){
                    requestedAction = -1;
                    continue;
                }
                modifyEmployees(requestedAction, employeeData, vacationData); 
            }
            
        }
        // Add Payroll
        if(nextMenu == 1){

        }
        // Vacation Days
        if(nextMenu == 2){

        }
        // Exit Program
        if(nextMenu == 3){
            isRequestedExit = true;
        }

    }while(!isRequestedExit);

    }
    /*
    Separating the logic for each submenu so that the main function remains    
    readable and not too cluttered
    */

    static void modifyEmployees(int request, EmployeeData employeeData, VacationTimeData vacationData){
        
        // list all current employees
        if(request == 0){
            employeeData.DisplayAllEmployees();
        }
        // add new employee
        if(request == 1){
            Employee emp = new Employee();
            while(true){
                Console.Write("Enter a unique id: ");
                string id = Console.ReadLine();
                if(employeeData.UniqueId(id)){
                    emp.id = id;
                    break;
                }
                else{
                    Console.WriteLine("Id already exists");
                    continue;
                }
            }
            Console.Write("Enter employee name: ");
            emp.name = Console.ReadLine();
            Console.Write("\nEnter employee address: ");
            emp.address = Console.ReadLine();
            Console.Write("\nEnter employee email: ");
            emp.email = Console.ReadLine();
            Console.Write("\nEnter employee phone number: ");
            emp.phone = Console.ReadLine();
            Console.Write("\nEnter employee role: ");
            emp.role = Console.ReadLine();
            
            employeeData.AddEmployee(emp);
        }


        Console.Write("Press any button to continue: ");
        Console.ReadKey();
        
    }

}
