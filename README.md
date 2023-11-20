# AlliedTask project description

**TwoSequencesSort.cs** file contains class with methods for performing the task.  
**Program.cs** file just consistently executes these methotds with given files A.txt and B.txt.  
**AlliedTaskTest.cs** contains few tests for methods from class in TwoSequencesSort.cs. Tests are written in NUnit Framework (which is based on JUnit).

**Here's the original task:**

There are two text files A and B, each containing a sorted sequence of integer numbers.  
Write a program which produces text file C containing sorted sequence of all numbers from files A and B.  
File A contains n numbers, file B contains m numbers, and the resulting file C must therefore contain n+m numbers.  
Each number in files A, B and C is stored on a separated line.

Memory consumption of the program must be O(1). Running time must be O(n+m).

Optional task: write unit tests for your code.
Optional task: write documentation for your code in JavaDoc format, in English.

**Example:**

Given file A:  
0  
1  
4  
7

Given file B:  
2  
4  
8

The produced file C should be:  
0  
1  
2  
4  
4  
7  
8
