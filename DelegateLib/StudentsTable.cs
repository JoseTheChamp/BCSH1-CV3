﻿namespace DelegateLib;

// TODO: Vytvořte delegát GetKeyCallback, který přijme objekt Student a vrací objekt IComparable. IComparable popisuje hodnotu klíče daného studenta.

// TODO: Dokončete třídu StudentsTable...
public class StudentsTable
{
    // TODO: Vytvořte vlastnost GetKey (delegáta GetKeyCallback), kterou lze číst a nastavovat (nebo jednorázově inicializovat).

    // Interní pole studentů.
    private StudentsArray students;

    // Delegovaná vlastnost pro zjištění kapacity pole.
    public int Capacity => students.Capacity;

    // Delegovaný indexer pro zjištění studenta na daném indexu.
    public Student? this[int index] => students[index];

    // Delegovaná metoda Sort pro umožnění řazení pole.
    public void Sort(CompareStudentsCallback callback) => students.Sort(callback);

    // Konstruktor.
    public StudentsTable(int capacity, GetKeyCallback getKeyCallback)
    {
        students = new StudentsArray(capacity);
        GetKey = getKeyCallback;
    }

    // TODO: Dokončete metodu Add - metoda přidá studenta do pole na první volný index.
    // Pokud již existuje student se stejným klíčem, pak metoda nedělá nic.
    // Pokud již není místo pro přidání studenta, pak metoda nedělá nic.
    public void Add(Student student)
    {
        // ...
    }

    // TODO: Dokončete metodu Get - metoda vyhledá studenta podle klíče.
    // Projďete pole studentů a vyhledejte studenta se shodným klíčem, pokud takový existuje, vraťte jej.
    // Pokud student neexistuje vraťte null.
    public Student? Get(IComparable key)
    {
        // ...
    }

    // TODO: Dokončete metodu Delete - metoda smaže studenta podle klíče.
    // Projďete pole studentů a studenta se shodným klíčem smažte (nahraďte jej hodnotou null), odstraněného studenta vraťte.
    // Pokud student neexistuje vraťte null.
    public Student? Delete(IComparable key)
    {
        // ...
    }
}
