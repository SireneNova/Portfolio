Day1-DataTypes.cs - The trick to this one was printing the number formatting correctly.

Day2-Operators.cs - Since C# is a strongly typed language, you get a completely different answer for this if you don't cast to double when multiplying by the ints. It will keep the result as an int and truncate decimal places.

Day4-ClassesInstances.cs is an exercise in creating a simple class, for a person, with certain properties and functions specified in the problem statement. It was my goal to make it clean, using traditional getters and setters. I chose for the getters and setters to be protected because it seemed they would not need to be externally called. A person can be instantiated with an age and functions of the class can be called that increment age and report if the person is "old" or not. The ages at which to decide what is "old" were given as part of the problem statement. 

Day6-Indexes - The instructions were to take a list of strings, print the even-index characters and odd-index characters separated by a space. First the user enters the number of strings they plan to enter, then the user enters each string. Then the string operations are performed and the console writes back the separated strings.
