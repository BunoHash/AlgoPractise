

using System;

public class Employee
{
    public string Name;
    public string Position;
    public string BloodGroup;
    public DateTime BirthDate ;

    public class Builder : EmployeeBloodGroupBuilder<Builder>
    {

    }

    public static Builder New => new Builder();


    public override string ToString()
    {
        return $"Name: {Name}, Position : {Position}, Birth Date : {BirthDate}, Blood Goup : {BloodGroup}";
    }

}

public abstract class EmployeeBuilder
{
    protected Employee employee = new Employee();
    public Employee Build(){
        return employee;
    }
}


public class EmployeeInfoBuilder<SELF> : EmployeeBuilder where SELF : EmployeeInfoBuilder<SELF>
{
    public SELF Called(string name){
        this.employee.Name = name;
        return (SELF) this;
    }
}

public class EmployeeJobBuilder<SELF> : EmployeeInfoBuilder<EmployeeJobBuilder<SELF>> where SELF: EmployeeJobBuilder<SELF>
{
    public SELF WorkAs(string positon){
        employee.Position = positon;
        return (SELF)this;
    }
}


public class EmployeeBirthDateBuilder<SELF> :  EmployeeJobBuilder<EmployeeBirthDateBuilder<SELF>> 
where SELF : EmployeeBirthDateBuilder<SELF>
{
    public SELF BornOn(DateTime birthday){
        employee.BirthDate = birthday;
        return (SELF) this;
    }
}

public class EmployeeBloodGroupBuilder<SELF> : EmployeeBirthDateBuilder<EmployeeBloodGroupBuilder<SELF>> where SELF : EmployeeBloodGroupBuilder<SELF>
{

    public SELF WithBloodGroup(string bloodGroup){
        employee.BloodGroup = bloodGroup;
        return (SELF) this;
    }
}




public static class FluidBuidlerExecuter 
{

    
    public static void Run(){

        var person = Employee.New
        .Called("Sayed")
        .WorkAs("Engineer")
        .BornOn(DateTime.UtcNow)
        .WithBloodGroup("A+")
        .Build();
        

        Console.WriteLine(person);

    }
}