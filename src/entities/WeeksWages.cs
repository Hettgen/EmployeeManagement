public class WeeksWages{

    public string id {get; set;}
    public string employeeId {get; set;}
    public double hoursWorked {get; set;}
    public double hourlyRate {get; set;}
    
    //Date will be the END of the week
    public DateTime date {get; set;}

    public WeeksWages(string id, string employeeId, double hoursWorked, double hourlyRate, DateTime date){
        this.id = id;
        this.employeeId = employeeId;
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
        this.date = date;
    }

    internal void Add(WeeksWages weeksWages)
    {
        throw new NotImplementedException();
    }
}