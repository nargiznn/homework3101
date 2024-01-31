// See https://aka.ms/new-console-template for more information
using System.Collections;
using praktika3101;

Console.WriteLine("Hello, World!");
StringList stringList = new StringList();
stringList.Add("Hikmet");
stringList.Add("Nazim");
stringList.Add("Nermin");
Console.WriteLine("\n===Name====");
for(int i = 0; i < stringList.Length; i++)
{
    Console.WriteLine(stringList[i]);
}

IntList numlist = new IntList();
numlist.Add(14);
numlist.Add(24);
numlist.Add(44);
Console.WriteLine("\n===Num====");
for (int i = 0; i < numlist.Length; i++)
{
    Console.WriteLine(numlist[i]);
}
Console.WriteLine("=====New=====");
string[] names = new string[] { "Nazim", "Nermin" };
int[] nums = new int[] { 14, 15, 17, 86 };
ArrayList arrList = new ArrayList();
arrList.Add(45);
arrList.Add("Hikmet");
arrList.AddRange(names);
arrList.RemoveAt(1);
Console.WriteLine("Capacity:");
Console.WriteLine(arrList.Capacity);
Console.WriteLine("Count");
Console.WriteLine(arrList.Count);
arrList.Clear();
arrList.Add(35);
arrList.Add("Nigar");
arrList.AddRange(nums);
arrList.RemoveRange(0, 2);
Console.WriteLine(arrList.Contains("Nigar"));
arrList.IndexOf(45);
arrList.Remove("Nigar");

foreach(var item in arrList)
{
    Console.WriteLine(item);
}
Console.WriteLine("===SortedList=====");
SortedList nonGenSortdList = new SortedList();
nonGenSortdList.Add("A103", 56);
nonGenSortdList.Add("A104", 46);
nonGenSortdList.Add("A102", 66);
nonGenSortdList.Add("A101", 56);
nonGenSortdList.Add("A105", 86);
Console.WriteLine(nonGenSortdList["A104"]);





