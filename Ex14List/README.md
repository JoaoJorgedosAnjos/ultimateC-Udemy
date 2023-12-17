# Ex04AbsoluteOfSum
Lists - GetOnlyUpperCaseWords
Implement the GetOnlyUpperCaseWords method, which given a collection of strings, returns a List with only those strings which contain only uppercase letters.

The result collection should not contain duplicates.

For example:

for input List {"one", "TWO", "THREE", "four"} the result shall be {"TWO", "THREE"}

for input List {"one", "TWO", "THREE", "four", "TWO"} the result shall be {"TWO", "THREE"} (the second "TWO" is ignored)

for input List {"one", "TWO123", "THREE!&^", "four"} the result shall be an empty List because no word in this collection is built from only uppercase letters (digits and special characters are not letters at all).

Tips:

Strings are collections of characters. It means we can iterate a string with a foreach loop, and in each iteration, we have access to a specific character from this string.