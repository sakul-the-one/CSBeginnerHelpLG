## Main Differenz
### The Main Differenz is, that File.cs is static, and FileData.cs  not, so since we know this, let's Code something with this!

```cs

FileData Learning;
//Create a Variable of the Class
public void Write()
{
Learning = new FileData(); //decleclears the Variable
Learning.path = @"C:/Saves/LearningData.txt");//Set the Path to the Variable
Learning.write( "Hello!");//Write in the Variable
File.write(@"C:\Saves\Learning.txt", "bye")//Write in the Static one
}
```
### That were the Main Stuff! Easy, right?
Now let's try to read a file ( **Place the Code under the last one!**)
```cs
public void Read(){
string Text1 = Learning.read();//Read from the Variable Above
string Text2 = File.read(@":\Saves\Learning.txt");//Read on the Static Field
}
```
### Still easy, right? One thing left...
The last function we got, is Start a exe File! Since we can't not start a .txt File, I will just show you the static way, but you still know how it would work on other way, right? (**You can place it again under the last one, but here it is not nessescearly
```cs
public void MyGame() {
File.start(@"C:\Games\MyGame\Game.exe");
}
```
### We are finish now! 
We have talked about all functions there and how it works, I hope it helps allot in fast programming!
