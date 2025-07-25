﻿// See https://aka.ms/new-console-template for more information
// Name: James King II
// Date: June 25, 2025
// Lab 5 - Madlibs#1
Console.WriteLine("Welcome to Mad Libs!");
Console.WriteLine("You'll be asked for different types of words to complete a funny vacation story.");
string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";
string[] storyWords = originalStory.Split(' ');
string newStory = "";
foreach (string word in storyWords)
{
    if (word.StartsWith("("))
    {
        
        string type = word.Trim('(', ')', '.', ',', '!', '?');
        
        
        string article = "a";
        if ("aeiou".Contains(type.ToLower()[0]))
            article = "an";

        Console.Write($"Please enter {article} {type}: ");
        string input = Console.ReadLine()!;

        
        string end = "";
        if (!char.IsLetterOrDigit(word[^1]))
            end = word[^1].ToString();

        newStory += input + end + " ";
    }
    else
    {
        newStory += word + " ";
    }
}
Console.WriteLine("\nHere's your Mad Libs story:");
Console.WriteLine(newStory);

