using System;

class Person
{
    private string _firstName;
    private string _lastName;
    private string _birthDate;
    private string _addressLine1;
    private string _addressLine2;
    private string _city;
    private string _state;
    private string _country;
    private int _zip;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public string BirthDate
    {
        get { return _birthDate; }
        set { _birthDate = value; }
    }
    public string AddressLine1
    {
        get { return _addressLine1; }
        set { _addressLine1 = value; }
    }
    public string AddressLine2
    {
        get { return _addressLine2; }
        set { _addressLine2 = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string State
    {
        get { return _state; }

        set { _state = value; }
    }
    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
    public int Zip
    {
        get { return _zip; }
        set { _zip = value; }
    }

    public Person()
    {
        FirstName = "Default";
        LastName = "Student";
        BirthDate = "05/24/1992";
        AddressLine1 = "NA";
        AddressLine2 = "NA";
        City = "NA";
        State = "NA";
        Zip = 10000;
        Country = "NA";
        studentCount++;
    }
    public Person(string first, string last, string birth, string a1, string a2, string cityVar, string stateVar, int zipCode, string countryVar)
    {
        FirstName = first;
        LastName = last;
        BirthDate = birth;
        AddressLine1 = a1;
        AddressLine2 = a2;
        City = cityVar;
        State = stateVar;
        Zip = zipCode;
        Country = countryVar;
        studentCount++;
    }

    public Person()
	{
	}
}
