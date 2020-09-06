

using System;

public class Person
{
    public string Name;
    public string Position;
    public string BloodGroup;
    public DateTime BirthDate ;

    public class Builder : PersonBloodGroupBuilder<Builder>
    {

    }

    public static Builder New => new Builder();


    public override string ToString()
    {
        return $"Name: {Name}, Position : {Position}, Birth Date : {BirthDate}, Blood Goup : {BloodGroup}";
    }

}

public abstract class PersionBuilder
{
    protected Person person = new Person();
    public Person Build(){
        return person;
    }
}


public class PersionInfoBuilder<SELF> : PersionBuilder where SELF : PersionInfoBuilder<SELF>
{
    public SELF Called(string name){
        this.person.Name = name;
        return (SELF) this;
    }
}

public class PersonJobBuilder<SELF> : PersionInfoBuilder<PersonJobBuilder<SELF>> where SELF: PersonJobBuilder<SELF>
{
    public SELF WorkAs(string positon){
        person.Position = positon;
        return (SELF)this;
    }
}


public class PersonBirthDateBuilder<SELF> :  PersonJobBuilder<PersonBirthDateBuilder<SELF>> 
where SELF : PersonBirthDateBuilder<SELF>
{
    public SELF BornOn(DateTime birthday){
        person.BirthDate = birthday;
        return (SELF) this;
    }
}

public class PersonBloodGroupBuilder<SELF> : PersonBirthDateBuilder<PersonBloodGroupBuilder<SELF>> where SELF : PersonBloodGroupBuilder<SELF>
{

    public SELF WithBloodGroup(string bloodGroup){
        person.BloodGroup = bloodGroup;
        return (SELF) this;
    }
}




public static class FluidBuidlerExecuter 
{

    
    public static void Run(){

        var person = Person.New
        .Called("Sayed")
        .WorkAs("Engineer")
        .BornOn(DateTime.UtcNow)
        .WithBloodGroup("A+")
        .Build();
        

        Console.WriteLine(person);

    }
}