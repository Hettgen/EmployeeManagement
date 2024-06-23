public class WeeksWagesData{

    private List<WeeksWages> weeksWages;
    private VacationTimeData vacationTimeData;

    public WeeksWagesData(VacationTimeData vacationTimeData){
            weeksWages = new List<WeeksWages>();
            this.vacationTimeData = vacationTimeData;
    }

    public void AddWeeksWages(WeeksWages weeksWages){
            weeksWages.Add(weeksWages);
            vacationTimeData.IncrementVacationDays(weeksWages.employeeId);
        }


}