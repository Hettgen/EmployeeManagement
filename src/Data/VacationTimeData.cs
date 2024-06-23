public class VacationTimeData{

    private List<VacationTime> vacationTimes;
    
    
    public VacationTimeData(){
        vacationTimes = new List<VacationTime>();
    }

    public List<VacationTime> GetAllVacationTimes(){
        return vacationTimes;
    }

    public void AddVacationTime(VacationTime vacationTime){
            vacationTimes.Add(vacationTime);
    }

    public void DeleteVacationTime(string id){
            var vacationTime = vacationTimes.SingleOrDefault(v => v.id == id);
            if (vacationTime != null){
                vacationTimes.Remove(vacationTime);
        }
    }

    public void IncrementVacationDays(string id){
        var existingVacationDays = vacationTimes.SingleOrDefault(e => e.employeeId == id);
        if(existingVacationDays != null){
            existingVacationDays.numberOfDays += 1;
        }
    }

}