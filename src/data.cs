using System;
using System.Collections.Generic;
using System.Linq;

public class Data{


    // Creating lists to store data and adding preloaded data
    public static List<Employee> employees = new List<Employee>{
        new Employee("001", "Stefan Hettgen", "1335 Montclair Drive", "hettgen49@gmail.com", "(289)834-9902", "Software Engineer"),
        new Employee("002", "George Hotz", "1050 Falgarwood Drive", "ghotz@gmail.com", "(918)443-2135", "Software Engineer"),
        new Employee("003", "Gregory Smith", "987 Parklane Drive", "GregSmith@gmail.com", "(709)727-9505", "Team Lead"),
        new Employee("004", "David Grayson", "1250 Beaumont Avenue", "grayson@gmail.com", "(604)797-6620", "System Administrator"),
        new Employee("005", "Adam Lucas", "670 Princess Anne Crescent", "aLucas@gmail.com", "(306)393-5294", "Manager")
    };
    public static List<WeeksWages> WeeksWagesList = new List<WeeksWages>{
    // Stefan Hettgen
    new WeeksWages("001", "001", 40, 50, new DateTime(2024, 6, 14)),
    new WeeksWages("002", "001", 42, 50, new DateTime(2024, 6, 21)),

    // George Hotz
    new WeeksWages("003", "002", 38, 55, new DateTime(2024, 6, 14)),
    new WeeksWages("004", "002", 40, 55, new DateTime(2024, 6, 21)),

    // Gregory Smith
    new WeeksWages("005", "003", 40, 70, new DateTime(2024, 6, 14)),
    new WeeksWages("006", "003", 45, 70, new DateTime(2024, 6, 21)),

    // David Grayson
    new WeeksWages("007", "004", 35, 45, new DateTime(2024, 6, 14)),
    new WeeksWages("008", "004", 38, 45, new DateTime(2024, 6, 21)),

    // Adam Lucas
    new WeeksWages("009", "005", 57, 100, new DateTime(2024, 6, 14)),
    new WeeksWages("010", "005", 55, 100, new DateTime(2024, 6, 21)),
    };
    public static List<VacationTime> VacationTimes = new List<VacationTime>{
        new VacationTime("001", "001", 10), // Stefan Hettgen
        new VacationTime("002", "002", 15), // George Hotz
        new VacationTime("003", "003", 8),  // Gregory Smith
        new VacationTime("004", "004", 12), // David Grayson
        new VacationTime("005", "005", 20)  // Adam Lucas
    };


}