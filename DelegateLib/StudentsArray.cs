namespace DelegateLib;

// TODO: Vytvořte delegát CompareStudentsCallback, který přijme pomocí dvou parametrů dva objekty "Student?" a umožní je porovnat.
// Výsledek porovnání může být ve tvaru: "první student je menší než druhý", "první student není menší než druhý".
// Nebo: "první student je menší než druhý", "první student je shodný s druhým", "první student je větší než druhý".

// TODO: Dokončete třídu StudentsArray...
public class StudentsArray
{

    public delegate void CompareStudentsCallback(Student student);

    // Interní pole studentů.
    private Student?[] students;

    // Kapacita pole studentů.
    public int Capacity => students.Length;

    // Indexer - umožňuje pracovat s objektem podobně jako s polem (objekt[index]).
    // Tento indexer umožňuje studenty číst i zapisovat, při zadání neplatných hodnot indexů se nevykoná žádná operace nebo je vrácena hodnota null.
    public Student? this[int index]
    {
        get
        {
            if (index < 0 || index >= students.Length)
                return null;

            return students[index];
        }

        set
        {
            if (index < 0 || index >= students.Length)
                return;

            students[index] = value;
        }
    }

    // TODO: Dokončete konstruktor a inicializujte pole na danou kapacitu
    public StudentsArray(int capacity)
    {
        students = new Student[capacity];
        
    }

    // TODO: Dokončete řadící algoritmus a uspořádejte všechny nenulové položky v poli dle porovnávací funkce předané delegátem v parametru.
    public void Sort(CompareStudentsCallback callback)
    {

    }



}
