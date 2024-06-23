public class VacationTime{

    public string id {get; set;}
    public string employeeId {get; set;}
    public int numberOfDays {get; set;}

    public VacationTime(string id, string employeeId, int numberOfDays){
        this.id = id;
        this.employeeId = employeeId;
        this.numberOfDays = numberOfDays;
    }

}