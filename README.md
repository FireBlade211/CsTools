# CsTools
A C# utility library.

# Examples
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

# Usage
To use the library, download the DLL from the [Releases](https://github.com/FireBlade211/CsTools/releases) page, and add it as a reference in your project within Visual Studio.
The base namespace is `FireBlade.CsTools`. For the math functions and utilities, use `FireBlade.CsTools.Numbers`.

For documentation, visit the [CsTools documentation page](https://fireblade211.github.io/CsTools/).
