# LPS_Logical_and_Review_Code

**Please refer to Program.cs and folder Class for more detail and you can run the console also.**

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

**A.6** This code creates a TreeNode object as the root node of a tree structure. The program then repeatedly creates new subtrees of 10,000 nodes and adds them as children of the root node. However, the program never removes the old subtrees, so it continues using up memory.

To fix this issue, modify the TreeNode class to expose the child nodes as public property, then create a RemoveChildAt method:
```
// remove the old subtrees to free up memory 
if (rootNode.Children.Count > 10)
{
  rootNode.RemoveChildAt(0);
}
```

**A.7** Improper caching can cause memory leaks in a C# program because objects that are cached and no longer needed can remain in memory.
To solve those memory leaks, you must implement the cache needs in a way that allows for the lifespan of cached objects to be managed. You can use a cache that automatically removes objects after a certain period or when the cache becomes too large.
```
// remove the old subtrees to free up memory 
CachedItem item = _cache[key];
if (item.Expiration < DateTime.Now)
{
  _cache.Remove(key);
  return null;
}
return item.Value;
```
