using System;
using System.IO;
public class CopyFileAddLineNumber 
{
	public static void Main(string[] args) 
	{
		try 
		{
			FileStream fin = new FileStream(
                "CopyFileAddLineNumber.cs", FileMode.Open, FileAccess.Read );
			FileStream fout = new FileStream(
                "CopyFileAddLineNumber.txt", FileMode.Create, FileAccess.Write );

			StreamReader brin = new StreamReader( 
				fin, System.Text.Encoding.Default );
			StreamWriter brout  = new StreamWriter(
				fout, System.Text.Encoding.Default );

			int cnt = 0;	// �к�
			for (string s = brin.ReadLine(); s != null; s = brin.ReadLine()){
				cnt ++; 
				s = deleteComments(s);			        //ȥ����//��ʼ��ע��
				brout.WriteLine(cnt + ": \t" + s );	    //д��
				Console.WriteLine(cnt + ": \t" + s );	//�ڿ�������ʾ
			}			
			brin.Close();				// �رջ�����������ļ�������������.
			brout.Close();
		} 
		catch (FileNotFoundException e) 
		{
			Console.WriteLine($"File {e.FileName} not found!+" );
		} 
		catch (IOException e2) 
		{
			Console.WriteLine( e2 );
		}
	}

	static string deleteComments( string s ) //ȥ����//��ʼ��ע��
	{
		if( s==null ) return s;
		int pos = s.IndexOf( "//" );
		if( pos<0 ) return s;
		return s.Substring( 0, pos );
	}
}
