

class Lab2 {
    
    public void findMax() {
        Console.WriteLine("Введіть розмірність масива для пошуку найбільшого числа");
        int masLength = Convert.ToInt16(Console.ReadLine());   
        int[] mas =new int [masLength];

        Console.WriteLine("Введіть елементи масива для пошуку найбільшого числа");
        for (int i = 0; i < masLength; i++) {
            mas[i] = Convert.ToInt16(Console.ReadLine());
        } 

        int result= mas.Max();
        Console.WriteLine("Найбільше число в масиві:"+ result);
    }

    public void findScalarProduct() {
        int[] firstVector = new int[3];
        int[] secondVector = new int[3];

        Console.WriteLine("Введіть координати першого вектора для пошуку скалярного добутку");
        for (int i = 0; i < 3; i++)
        {
            firstVector[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Введіть координати другого вектора для пошуку скалярного добутку");
        for (int i = 0; i < 3; i++)
        {
            secondVector[i] = Convert.ToInt16(Console.ReadLine());
        }

        int dotProduct = 0;
        for (int i = 0; i < firstVector.Length; i++)
        {
            dotProduct += firstVector[i] * secondVector[i];
        }

        Console.WriteLine("Скалярний добуток введених векторів дорінює "+ dotProduct);

    }

    public void sortMas() {
        Console.WriteLine("Введіть розмірність масиву для сортування");
        int masLength = Convert.ToInt16(Console.ReadLine());
        int[] mas = new int[masLength];

        Console.WriteLine("Введіть елементи масиву для сортування");
        for (int i = 0; i < masLength; i++)
        {
            mas[i] = Convert.ToInt16(Console.ReadLine());
        }

        Array.Sort(mas);
        Array.Reverse(mas);

        Console.WriteLine("Відсортований масив: ");
        foreach (int massiv in mas) {
            Console.WriteLine(massiv);
        };
    }

    public void sortMasColumns() {
        Console.WriteLine("Введіть к-ть рядків двовимірного масиву для сортування");
        int masRows = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Введіть к-ть стовпців двовимірного масиву для сортування");
        int masColumns = Convert.ToInt16(Console.ReadLine());
        int[,] mas = new int[masRows, masColumns];

        Console.WriteLine("Введіть елементи двовимірного масиву для сортування");
        for (int i = 0; i < mas.GetLength(0); i++)  
        {
            for (int j = 0; j < mas.GetLength(1); j++)  
            {
                mas[i,j] = Convert.ToInt16(Console.ReadLine());
            }
        }

        int columns = mas.GetLength(1);

        for (int j = 0; j < columns; j += 2)
        {
            int[] column = new int[mas.GetLength(0)];  
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                column[i] = mas[i, j];  
            }
            Array.Sort(column);  
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                mas[i, j] = column[i];  
            }
        }


        Console.WriteLine("Відсортований масив:");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write("{0,3}", mas[i, j]);  
            }
            Console.WriteLine(); 
        }
    }

    public void findZeroColumns() {
        Console.WriteLine("Введіть к-ть рядків двовимірного масиву для пошуку стовпців з нулями");
        int masRows = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Введіть к-ть стовпців двовимірного масиву для пошуку стовпців з нулями");
        int masColumns = Convert.ToInt16(Console.ReadLine());
        int[,] mas = new int[masRows, masColumns];

        Console.WriteLine("Введіть елементи двовимірного масиву для пошуку стовпців з нулями");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                mas[i, j] = Convert.ToInt16(Console.ReadLine());
            }
        }

        int counter = 0;

        for (int i = 0; i < mas.GetLength(1); i++)
        {
            for (int j = 0; j < mas.GetLength(0); j++)
            {
                if (mas[j, i] == 0)
                {
                    counter++;
                    break;
                }
            }
        }
        Console.WriteLine("Введений масив:");

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write("{0,3}", mas[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("К-ть стовпців з нульовими елементами: "+counter);
        }
    public void findSameElementsRange() {
        Console.WriteLine("Введіть к-ть рядків двовимірного масиву для пошуку рядку з найдовшої серії однакових елементів");
        int masRows = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Введіть к-ть стовпців двовимірного масиву для пошуку рядку з найдовшої серії однакових елементів");
        int masColumns = Convert.ToInt16(Console.ReadLine());
        int[,] mas = new int[masRows, masColumns];

        Console.WriteLine("Введіть елементи двовимірного масиву для пошуку рядку з найдовшої серії однакових елементів");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                mas[i, j] = Convert.ToInt16(Console.ReadLine());
            }
        }

        int maxSequenceLength = 0;
        int maxSequenceRow = -1;

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            int sequenceLength = 1;
            for (int j = 1; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] == mas[i, j - 1])
                {
                    sequenceLength++;
                }
                else
                {
                    if (sequenceLength > maxSequenceLength)
                    {
                        maxSequenceLength = sequenceLength;
                        maxSequenceRow = i;
                    }
                    sequenceLength = 1;
                }
            }

            if (sequenceLength > maxSequenceLength)
            {
                maxSequenceLength = sequenceLength;
                maxSequenceRow = i;
            }
        }
        Console.WriteLine("Введений масив:");

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write("{0,3}", mas[i, j]);
            }
            Console.WriteLine();
        }

        if (maxSequenceRow == -1)
        {
            Console.WriteLine("Найдовшої серії одинакових елементів не знайдено");
        }
        else
        {
            Console.WriteLine("Номер рядка з найдовшою серією одинакових елементів: " + (maxSequenceRow+1));
        }
    }

        public static void Main(String[] args) {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Lab2 l2 = new Lab2();

        l2.findMax();
        l2.findScalarProduct();
        l2.sortMas();
        l2.sortMasColumns();
        l2.findZeroColumns();
        l2.findSameElementsRange();
    }
}
