using System;
using System.Collections.Generic;


namespace DP.Creational.Builder
    {
    public class Person
    {
        public string StreetAddress, PostCode, City;
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }




    public class PersonBuilder // facade
    {
        protected Person person = new Person();
        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Reside => new PersonAddressBuilder(person);
        public static implicit operator Person(PersonBuilder pb)
        {
        return pb.person;
        }

    }

    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder AtStreet (string streetAddress){
            this.person.StreetAddress = streetAddress;
            return this;
        }
        public PersonAddressBuilder AtCity (string city){
            this.person.City = city;
            return this;
        }
        public PersonAddressBuilder WithPostCode (string postCode){
            this.person.PostCode = postCode;
            return this;
        }

    }

    public class PersonJobBuilder : PersonBuilder
    {

        public PersonJobBuilder (Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At( string companyName){
            this.person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position){
            this.person.Position = position;
            return this;

        }

        public PersonJobBuilder Earning(int annualIncome){
            this.person.AnnualIncome = annualIncome;
            return this;

        }
    }



    public class ExecuteFacadeBuilder {

        public static void Run(){

            var employeeBuilder = new PersonBuilder();
            Person employee = employeeBuilder
            .Reside.AtStreet("12/3 Dhaka")
            .AtCity("Dhaka").WithPostCode("1236")
            .Works.At("Macdonalrs")
            .AsA("Site Manager")
            .Earning(30000);

            Console.WriteLine(employee.ToString());

        }
    }
}