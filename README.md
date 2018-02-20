# IEnumerableDeepDive
Shows IEnumerable is NOT an array

An IEnumerable<T> only has one real function in it.  GetEnumerator as seen [here](https://msdn.microsoft.com/en-us/library/s793z9y2(v=vs.110).aspx).  All the rest of the functions are extension methods.  What is an enumerator?  An enumerator is the object that actually goes through a set and returns each value.  As set can be anything ienumerable, an array, a dictionary, a list...So think of a guy with a folder that has sheets of paper.  Each sheet has a number on it.  When an enumerator is created, it references item -1.  MoveNext hasn't been called.  When it is it gets item 0.  It opens the folder and reads the number on sheet 1.  When the value is done being used the next value is read, and so on till all the values are read.  Think of this as a pull architecture.  Pull value 1, do stuff, pull value 2...  This is what for each loops use.  They use the enumerator.  
  
  Linq just sits on top of the IEnumerable interface and adds all kinds of extension methods that use the IEnumerable and then return a new IEnumerable.  For example, the Take extension only takes up to x items even if the ienumerable has more.
