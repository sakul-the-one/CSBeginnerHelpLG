# The Box.cs File now! Here we go!
## The Box.cs File is not harder then File.ca and FileData.cs, it's very easy!
Let's Beginn with the functions!
```cs
public void Say-Something(){
Box.say("I wanna to say something"); //Very fast to say something!
```
## Easy like always, right???
The Reason why I made this class, is because on that way it's faster then the normal Class from Windows, hope you are now on more Speed!
How about to make some information, right?
```cs 
public void Information(){
Box.inform("A information", this program has just dark mode, be happy about it!");
}
```
## That's how to inform someone! 
but what we do if the User made a error, that provides a Script error?
```cs
private float  ToNumber(string input = textbox1.text) //I take a TextBox as Standard, since often a user needs to input it
{
float Number
try //Start the Try Block 
{ 
Convert.ToFloat(input);
}
catch
{ 
Box.error("Error", "Was this a Number? Try it again!");
}
}
```
## Just one thing left!
If you have tested them, you saw that there was just one Button, but what about to ask a Question?
```cs 
public void Question() {
bool Yes = Box.ask("A Question", "Do you wanna use DarkMode?");
if (Yes == true)
{
this.color = Black;
} else {
this.color = White;
}
} 
```
## Mission compledet, easy like always!
If this with the 'this.color' not works, say it! I will fix it, but that was basically the class Box, I hope you liked it!
###### Any Suggestions? Say them!
