using System;

namespace Study_Practice;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Problem_000 Problem = new Problem_391();
        // Problem_000 Problem = new Practice_Space();
        Problem.Solution();
    }
}