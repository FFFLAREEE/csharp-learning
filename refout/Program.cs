namespace refout
{
	// ref out
	class MainClass
	{
		static bool MyMethod(ref int number, out float result)//标注了ref的要用引用的方式来传递
		//值类型的变量在传递的时候传递的是副本
		//引用传递的话可以理解为直接把本体传过去了
		//out的意思是这是一个输出参数（用来往外传递结果） ref 是往里传递
		//ref可以用来高效的传递值类型
		{
			number = 100;
			result = 3.1415926f;
			return true;
		}
		static bool MyMethod2(in int number2, out float result)
		//in 也是一种引用传递 但是它是只读传递
		//并且与ref out 不同，在调用的时候前面不需要加 in
		{
			
			result = 3.1415926f;
			return true;
		}

		static void Main()
		{
			int number=0;
			float r;
			MyMethod(ref number, out r);
			
			Console.WriteLine(number);
			Console.WriteLine(r);
		}
		
		
		
	}
}