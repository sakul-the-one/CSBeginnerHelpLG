# Always wanted to run a Code in C#, but dont know how? Here is a way!
## First we do it with C#!
```cs
public void RunCS() 
{
   List<string> Assembles = new List<string>(); 
   Assembles.Add("System.dll");
   string CSCode = "using System;namespace Running{class programm{ public void Main(string[] args) {Console.WriteLine("Hello World"); Console.ReadLine();}}}";
   string Output = "Console.exe";
   string ConsoleOutput = Convert.ToString(Eval.CSEval(CSCode, Output, Assembles));
}
```
## Its a bit harder then the other, but it not so hard, right???
