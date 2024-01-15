using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Linq;
int n = 9119;
int[] ints = n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
for (int i = 0; i < ints.Length; i++)
    ints[i] *= ints[i];
Console.WriteLine(int.Parse(string.Join("", ints.Select(x => x.ToString()))));