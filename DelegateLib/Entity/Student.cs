namespace DelegateLib;

// TODO: Vytvořte třídu Student...
//
// Třída Student obsahuje následující vlastnosti (pro čtení i zápis):
// - string? Name
// - int Number
// - Faculty Faculty
//
// Vytvořte bezparametrický konstruktor.
// Vytvořte parametrický konstruktor pro nastavení všech vlastností (parametry v pořadí dle výše uvedeného).
//
// Přetižte metodu ToString() tak, aby vracela výstup ve tvaru: JmenoStudenta (CisloStudenta, ZkratkaFakulty)
//
public class Student {

    public string? Name { get; set; }
    public int Number { get; set; }
    public Faculty Faculty { get; set; }

    public Student()
    {
    }

    public Student(string? name, int number, Faculty faculty)
    {
        Name = name;
        Number = number;
        Faculty = faculty;
    }



    public override string? ToString()
    {
        return (Name ?? "BezJmena") + " (" + Number + ", " + Faculty + ")";
    }

    public override bool Equals(object? obj)
    {
        return obj is Student student &&
               Name == student.Name &&
               Number == student.Number &&
               Faculty == student.Faculty;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Number, Faculty);
    }
}