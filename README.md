# LPS_Logical_and_Review_Code

Please refer to Program.cs and folder Class for more detail.

**A.1** The "If" statement is correct to check null. but it can be stated a little better to use NULL coalescing operators instead of if statement for cleaner and easier to read code.
example :
```
public double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
{
  return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
}
```
**A.2** Use Tuple Instead Off Classes, for simple way to return more than one value with dynamic return type
example :
```
public (string Path, string Name) GetApplicationInfo()
{
  return ("C:/apps/", "Shield.exe");
}
```
**A.3** It is not good practice to have the ability to modify members. You have to be careful which of them can be modified or not. If the member will not be modified, it is better not to use set; to avoid any accidental (or intentional) modification in the future.
 example :
```
class Laptop
{
  public string Os { get; } // not use "set;". can not be modified.
  public Laptop(string os)
  {
    Os = os;
  }
}
```
**A.4** Keeping references to objects unnecessarily in C# programs can lead to memory leaks and slow. The C# program creates a list of integers called myList and then enters an infinite loop.
use myList.Clear(); for Removing objects or data that are no longer needed to preventing memory leaks, example :
```
//clear the list and set its reference to null 
myList.Clear();
```

**A.5** he program never detaches the OnMyEvent method from the event, which causes the EventSubscriber object to stay alive even when it’s no longer needed.
To fix this issue, detach the OnMyEvent method from the event in the EventSubscriber object’s destructor:
```
public void Dispose() 
{ 
  Dispose(true); 
  GC.SuppressFinalize(this); 
} 
```
