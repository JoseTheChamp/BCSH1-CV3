namespace DelegateLib
{
    public class StudentsArrayBase
    {

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
    }
}