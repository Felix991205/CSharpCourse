using System;
class ClassA
{
   
    protected int  b=20;
	public int a = 10;
	public void Method1() {
		a++;
        Console.WriteLine(a);
	}
	public virtual void Method2(){
		Console.WriteLine("ClassA.Method2");
	}
}
class ClassB : ClassA
{
	 new public int a = 20;

	 new public void Method1() { 
		a++;
        Console.WriteLine(a);
	}
	public override void Method2(){
		Console.WriteLine("ClassB.Method2");
	}
	static void Main()
	{
        ClassB y = new ClassB();
        Console.WriteLine(y.a); //��ʾ20
        y.Method1(); //��ʾ21
        y.Method2();


        ClassA x = new ClassB(); 
		Console.WriteLine( x.a ); //��ʾ10
		x.Method1(); //��ʾ11
		x.Method2(); //��ʾ""ClassB.Method2" 
    }
}