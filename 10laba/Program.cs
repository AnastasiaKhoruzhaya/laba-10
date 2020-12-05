/*1. Создать необобщенную коллекцию ArrayList.
a. Заполните ее 5-ю случайными целыми числами
b. Добавьте к ней строку
c. Добавьте объект типа Student
d. Удалите заданный элемент
e. Выведите количество элементов и коллекцию на консоль.
f. Выполните поиск в коллекции значения
2. Создать обобщенную коллекцию в соответствии с вариантом задания и
заполнить ее данными, тип которых определяется вариантом задания (колонка
– первый тип).
a. Вывести коллекцию на консоль
b. Удалите из коллекции n последовательных элементов
c. Добавьте другие элементы (используйте все возможные методы
добавления для вашего типа коллекции).
d. Создайте вторую коллекцию (см. таблицу) и заполните ее данными из
первой коллекции.
e. Выведите вторую коллекцию на консоль. В случае не совпадения
количества параметров (например, LinkedList<T> и Dictionary<Tkey,
TValue>), при нехватке - генерируйте ключи, в случае избыточности –
оставляйте TValue.
f. Найдите во второй коллекции заданное значение.


Dictionary<Tkey, TValue> int HashSet<T>
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace laba10
{
    class Student
    {
        public string name;
        public int age;

        public Student(string n, int a)
        {
            name = n;
            age = a;
        }
        public override string ToString()
        {
            return ("Name: " + name + " Age: " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();//Заполните ее 5-ю случайными целыми числами
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(0, 5));
            }
            void Output()
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Console.Write(arrayList[i] + " ");
                }
            }
            arrayList.Add("I don't know");//Добавьте к ней строку
            arrayList.Add(new Student("Nastya", 19));//Добавьте объект типа Student
            Output();
            Console.WriteLine();
            arrayList.Remove(arrayList[2]);//Удалите заданный элемент
            Output();
            Console.WriteLine("\n" + arrayList.Count);//Выведите количество элементов и коллекцию на консоль.
            if (arrayList.Contains(5))//Выполните поиск в коллекции значения
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            /////////////////////////////
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                [28] = "Ola"//Добавьте другие элементы (используйте все возможные методы добавления для вашего типа коллекции).
            };
            dictionary.Add(18, "Daria");
            dictionary.Add(19, "Nastya");
            dictionary.Add(20, "Tanya");
            dictionary.Add(25, "Polina");
            dictionary.Add(17, "Kate");
            dictionary.Add(21, "Ksenya");

            foreach (KeyValuePair<int, string> keyValue in dictionary)//Вывести коллекцию на консоль
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }
            Console.WriteLine();
            int n = 18;
            for (int i = 0; i < 2; i++)//Удалите из коллекции n последовательных элементов
            {
                dictionary.Remove(n); n++;
            }
            foreach (KeyValuePair<int, string> keyValue in dictionary)//Вывести коллекцию на консоль
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }
            /////////////////////
            HashSet<string> set = new HashSet<string>();

            foreach (string str in dictionary.Values)//Создайте вторую коллекцию (см. таблицу) и заполните ее данными из первой коллекции.
            {
                set.Add(str);
            }
            foreach (string str in set)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine("\n" + set.Contains("Tanya"));// Найдите во второй коллекции заданное значение.
        }
    }
}
