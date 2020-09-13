
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        var stream = new MemoryStream();
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, self);
        stream.Seek(0, SeekOrigin.Begin);
        object copyObject =  formatter.Deserialize(stream);
        stream.Close();
        return (T) copyObject;
    }

    public static T DeepXmlCopy<T>(this T self)
    {

        using(var stream = new MemoryStream())
        {
            var s = new XmlSerializer(typeof(T));
            s.Serialize(stream, self);
            stream.Position = 0 ;
            return (T) s.Deserialize(stream);
        }
    }

}

[Serializable]
public class Member 
{

    public Member()
    {
        
    }
    public string[] Names;
    public Address Address;
    public Member(string[] names, Address address)
    {
        this.Names = names;  
        this.Address = address; 
    }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)} : {Address}";
    }
}

[Serializable]
public class Address
{
    public Address()
    {
        
    }
    public string StreetName;
    public int HouseNumber;

    public Address(string street, int house)
    {
        this.StreetName = street;
        this.HouseNumber = house;
    }

    public override string ToString()
    {
        return $"{nameof(StreetName)} : {StreetName}, {nameof(HouseNumber)} : {HouseNumber}";
    }
}

public static class ExecutePrototype{

    public static void Run()
    {

        var jhon = new Member(new string[] {"Bob", "Raily"},
        new Address("Baker Street", 221));


        var jane = jhon.DeepXmlCopy();
        jane.Names[0] = "Jane";
        jane.Address.StreetName = "DOL";

        Console.WriteLine(jhon);
        Console.WriteLine(jane);



    }
}