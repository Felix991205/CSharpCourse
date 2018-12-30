using System;
class MyException : ApplicationException{
   	private int code;
 	public MyException(String message, int code) 
		:base(message){
			this.code = code;
 	} 

	public int Code { get => code; }
}

public class Test{
    public static void regist(int num) {
 	    if(num < 0) {
   			  Console.WriteLine("�ǼǺ���" + num );
 	          throw new MyException("����Ϊ��ֵ��������",3);
 	    }
    }
	public static void manager() {
 	    try {
	        regist(-100);
 	    } catch (MyException e) {
 	        Console.WriteLine("�Ǽ�ʧ�ܣ���������" + e.Code);
	    }
	    Console.WriteLine("���εǼǲ�������");
    }
	public static void Main(){
	    Test.manager();
    }
}
