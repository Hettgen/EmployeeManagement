class Menus{

    // Console menus will be created in here for sake of visual clarity when calling them


    // Main Menu

    static string header = "--------------------------------\n"+
        "EMPLOYEE AND PAYROLL MANAGEMENT\n"+
        "--------------------------------";

    private static readonly string[] mainMenu = {"1. Modify Employees", "2. Add Payroll", "3. Vacation Days", "4. Exit Program"};

    private static readonly string[] employeeMenu = {"1. List all current employees", "2. Add new employee", "3. Update an employee's profile", "4. Remove an employee", "5. Return to main menu"};

    private static readonly string[] payrollMenu = {"1. Insert new payroll entry", "2. View employee payroll history", "3. Return to main menu"};

    private static readonly string[] vacationMenu = {"1. View vacation days for employee", "2. Return to main menu"};

    // The main menu is the start of the menu loop, 
    // public static void Main(){
    //     Console.WriteLine("Hello");

    //     Boolean requestExit = false;
    //     int cursorPos = 0;
        
    //     int currentMenuLength = mainMenu.Length;

    //     string[] currentMenu = mainMenu;
    
    //     DisplayMenu(mainMenu);
        
        


        
    // }







//int currentLine
    // Displays any string array and allows navigation. Exits upon pressing enter and returns which line it was on
    public static int DisplayMenu(string[] menu){

        int currentLine = 0;
        bool menuFlag = true;
        
        do{
            Console.Clear();
            Console.WriteLine(header);

            for(int i = 0; i < menu.Length; i++){
                // to highlight current option that the user is hovering over
                if(i == currentLine){
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(menu[i]);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else{
                    Console.WriteLine(menu[i]);
                }
            }


            int userInput = getKeyInput();
            if(userInput != 2)
                currentLine = CheckLength(menu.Length ,currentLine + userInput);
            if(userInput == 2){
                menuFlag = false;
            }
        }while(menuFlag);

        return currentLine;
    }


    // These menu methods below are an implementation of the above menu display for each specific menu so that it can be more easily accessed outside of the class

    public static int MainMenu(){
        return DisplayMenu(mainMenu);
    }
    public static int EmployeeMenu(){
        return DisplayMenu(employeeMenu);
    }
    public static int PayrollMenu(){
        return DisplayMenu(payrollMenu);
    }
    public static int VacationMenu(){
        return DisplayMenu(vacationMenu);
    }


    // Tracking user key inputs for menu selection
    
    // Returns an integer that represents user input. 
    // -1 is up, 1 is down and 2 is enter, 0 means invalid input
    public static int getKeyInput(){

        ConsoleKey keyPress;    

        keyPress = Console.ReadKey().Key;
        switch(keyPress){
            case ConsoleKey.UpArrow:
                return -1;
            case ConsoleKey.DownArrow:
                return 1;
            case ConsoleKey.Enter:
                return 2;
            default:
                break;
        }
        return 0;
    }

    public static int CheckLength(int arrLen, int cursorPos){

        if(cursorPos > arrLen - 1){
            return 0;
        }
        if(cursorPos < 0){
            return arrLen - 1;
        }
        else{
            return cursorPos;
        }
    }


}

