///<remark>
/// Этот класс генерирует простые числа, не превышающие заданного
/// пользователем порога. В качестве алгоритма используется решето
/// Эратосфена.
/// Пусть дан массив целых чисел, начинающийся с 2:
/// Находим первое невычеркнутое число и вычеркиваем все его
/// кратные. Повторяем, пока в массиве не останется кратных.
///</remark>
using System;
public class PrimeGenerator
{
    private static bool[] f;
    private static int[] result;
    public static int[] GeneratePrimeNumbers(int maxValue)
    {
        if (maxValue < 2)
            return new int[0];
        else
        {
            InitializeArrayOfIntegers(maxValue);
            CrossOutMultiples();
            PutUncrossedIntegersIntoResult();
            return result;
        }
    }
    private static void InitializeArrayOfIntegers(int maxValue)
    {
        // объявления
        f = new bool[maxValue + 1];
        f[0] = f[1] = false; //не простые числа и не кратные
        for (int i = 2; i < f.Length; i++)
            f[i] = true;
    }
    private static void Sieve()
    {
        int i;
        int j;
        for (i = 2; i < Math.Sqrt(s) + 1; i++)
        {
            if (f[i]) // если i не вычеркнуто, вычеркнуть его кратные.
            {
                for (j = 2 * i; j < s; j += i)
                    f[j] = false; // кратное – не простое число
            }
        }
    }
    private static void InitializeSieve(int maxValue)
    {
        // объявления
        s = maxValue + 1; // размер массива
        f = new bool[s];
        int i;
        // инициализировать элементы массива значением true.
        for (i = 0; i < s; i++)
            f[i] = true;
        // исключить заведомо не простые числа
        f[0] = f[1] = false;
    }
}
