/* Array is a data structure
 Matrix is the name given to two-dimensional arrangements
 - Homogeneous (Data of the same type)
 - Sorted (Elements accessed through positions)
 - Allocated at once, In a contiguous block of memory

 Benefits:
 - Immediate access to elements based on their position
 
 Disadvantages:
 - Fixed size
 - Difficulties in performing insertion and deletions
*/

double[,] mat = new double[2, 3];

Console.WriteLine(mat.Length); // 6 (Total number of elements)
Console.WriteLine(mat.Rank); // 2 (Number of lines) 
Console.WriteLine(mat.GetLength(0)); // First dimension (Lines)
Console.WriteLine(mat.GetLength(1)); // Second dimension (Columns)

