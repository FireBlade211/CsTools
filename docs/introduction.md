# Introduction

**CsTools** is a C# utility library written in .NET 8. It provides common utilites of all types - strings, math tools, and others. For example, you can change and retrieve a casing mode for a string, or map numbers of any numeric type that exists (because of the generic INumber interface) from an input range to an output range.

## Example
```cs
myStr.IsNullOrEmpty();
myStr2.IsNullOrWhiteSpace();
myIntString.TryParseNumber<int>(out int val);

char[] chars = ['t', 'e', 's', 't'];
Console.WriteLine(chars.GetString()); // --> test

if ("Some Text".GetCasing() == StringCasing.Title)
{
  Console.WriteLine("Is title case!");
}

Console.WriteLine("RandomTest".SetCasing(StringCasing.Camel)); // --> randomTest

"Bob".IsPalindrome();

Console.WriteLine(MathTools.Map(5, new Range<int>(1, 10), new Range<int>(11, 20))); // --> 15

MathTools.Mod(10, 2);

MathTools.IsEven(6);
MathTools.IsOdd(3);
```