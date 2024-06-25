// See https://aka.ms/new-console-template for more information
using System.Collections;
using Tasks_OOP_SQL_;

Console.WriteLine("Hello, World!");

//public-bu metod ve ya deyisen her yerde elcatan olur
//private -yalniz eyni classin icerisinde olur
//protected-yalniz eyni class ve miras goturen classlar icerisinde istifade edile biler
//internal-yalniz eyni solution daxilinde istifade edile biler

int a = 5;
object b = a;//boxing
//Console.WriteLine(b + " " + a);
int c = (int)b;//unboxing

//Arraylist----------------------------------------------------------------
ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add(2);
arrayList.Add("Salam");
arrayList.Add(2.4f);

foreach (var i in arrayList)
{
    Console.WriteLine(i);
}

//out,ref------------------------------------------------------------------

int  d = 5;
d++;
Method1(ref d);
Console.WriteLine(d);//burada refden gelen deyeri goturur
Method2(out d);
Console.WriteLine(d);//outdan gelen d-ni goturur.
//out-da deyer metodun daxilinde elan olunmalidir.
//ref-de deyisen evvelceden melum olmalidir.

static void Method1(ref int a)
{
    a++;
    Console.WriteLine(a);
}

static void Method2(out int a)
{
    a = 4;
    a++;
    Console.WriteLine(a);
}


//is,as--------------------------------------------------------------------

int x = 7;
object y = 8;

if(x is long)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}

object obj = "Hello";
string str = obj as string;




List<int> list = new List<int>();//collection.generic-dir
list.Add(1);
list.Remove(1);

Queue<int> q = new Queue<int>();

q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
//dq.Dequeue();
q.Enqueue(7);
int l = q.Count;

for (int i = 0; i < l; i++)
{
    
    Console.WriteLine(q.Dequeue());
}

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
int l1 = stack.Count;
for (int i = 0; i < l1; i++)
{

    Console.WriteLine(stack.Pop());
}
//stack.ElementAt(0);//indexdeki elementi cixarir


Console.WriteLine("Dictionary");
Dictionary<int,int> dic = new Dictionary<int,int>();
int[] arr3 = new int[8] {1,2,3,3,4,5,7,7};


foreach(var item in arr3)
{
    if (dic.ContainsKey(item))
    {
        dic[item]++;
    }
    else
    {
        dic.Add(item, 1);
    }
    
}

MyEnum myEnum = new MyEnum();
myEnum = MyEnum.red;
MyEnum myEnum1 = new MyEnum();
myEnum1 = (MyEnum)4;//pink





public struct MyStruct
{
    public int x; public int y;
    
}

