using System;
using System.Collections;
using System.Collections.Generic;

namespace Generictype
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic Type
            //MyIntList myIntList = new MyIntList();
            //myIntList.AddItem(5);
            //myIntList.AddItem(15);
            //myIntList.AddItem(25);
            //myIntList.ShowItems();

            //MyStrList myStrList = new MyStrList();

            //MyList list = new MyList();
            //list.AddItem(5);
            //list.AddItem(15);
            //list.AddItem(25);
            //list.AddItem("Cefer");
            //list.AddItem(true);
            //list.AddItem(new int[] { 1,2,3});

            //MyList<int> intList = new MyList<int>();
            //intList.AddItem(5);
            //intList.AddItem(10);
            //intList.AddItem(25);

            //MyList<string> strList = new MyList<string>();
            //strList.AddItem("Cefer");

            //MyList<Student> stuList = new MyList<Student>();
            //stuList.AddItem(new Student());

            //Test<Student, IRun> test = new Test<Student, IRun>();
            //Test<string, object> test1 = new Test<string, object>();
            #endregion

            #region Collection
            #region Arraylist,List
            //ArrayList list = new ArrayList();
            //list.Add(5);
            //list.Add(true);
            //list.Add("aasf");
            //list.Add('a');
            //List<int> intList = new List<int>();
            //intList.Add(5);
            //intList.Add(15);
            //intList.Add(25);
            //intList.Add(35);
            ////foreach (int item in intList)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Console.WriteLine(intList.Contains(15));
            //Console.WriteLine(intList.Find(n=>n==0));
            #endregion

            #region HashTable,Dictionary,SortedList
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("name", "Cefer");
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran", "0512373434");
            //phones.Add("Nicat", "0515262222");
            //phones.Add("Cefer", "0773803880");
            //Console.WriteLine(phones["Cefer"]);
            //SortedList<int, string> sortLst = new SortedList<int, string>();
            //sortLst.Add(5, "Cefer");
            //sortLst.Add(2, "Faiq");
            //sortLst.Add(0, "Hashim");
            //sortLst.Add(1, "Abdulaziz");
            //foreach (var item in sortLst)
            //{
            //    Console.WriteLine(item);
            //}
            //SortedDictionary<>
            //LinkedList<int> test = new LinkedList<int>();
            #endregion

            #region Queue - FIFO
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine($"Suradaki:{queue.Peek()}");
            //queue.Dequeue();
            //Console.WriteLine("Novbedekiler:");
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack - LIFO
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //Console.WriteLine($"Suradaki:{stack.Peek()}");
            //stack.Pop();
            //Console.WriteLine("Novbedekiler:");
            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
    }

    #region Generic Type
    #region Wrong
    //class MyIntList
    //{
    //    private int[] arr;
    //    public MyIntList()
    //    {
    //        arr = new int[0];
    //    }

    //    public void AddItem(int item)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = item;
    //    }

    //    public void ShowItems()
    //    {
    //        foreach (int item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //class MyStrList
    //{
    //    private string[] arr;
    //    public MyStrList()
    //    {
    //        arr = new string[0];
    //    }

    //    public void AddItem(string item)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = item;
    //    }

    //    public void ShowItems()
    //    {
    //        foreach (string item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    #endregion

    #region Old version
    //class MyList
    //{
    //    private object[] arr;
    //    public MyList()
    //    {
    //        arr = new object[0];
    //    }

    //    public void AddItem(object item)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = item;
    //    }

    //    public void ShowItems()
    //    {
    //        foreach (object item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    #endregion

    //class Test<T, U> where T :U
    //class Test<T, U> where T:class where U:struct
    //{

    //}
    ////class MyList<T> where T:class
    ////class MyList<T> where T : struct
    ////class MyList<T> where T : IRun
    ////class MyList<T> where T : struct, IRun
    //class MyList<T> where T : class, IRun, new()
    //{
    //    private T[] arr;
    //    public MyList()
    //    {
    //        arr = new T[0];
    //    }

    //    public void AddItem(T item)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = item;
    //    }

    //    public void ShowItems()
    //    {
    //        foreach (T item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    //interface IRun
    //{

    //}

    //class Person
    //{

    //}
    //class Student:Person,IRun
    //{
        
    //}
    #endregion
}
