﻿using System.Text;

namespace GildedRoseKataTests;
public class ProgramTests
{
    [Fact]
    public void Program_GeneralTest()
    {
        var sb = new StringBuilder();
        Console.SetOut(new StringWriter(sb));
        Console.SetIn(new StringReader("a\n"));
        Program.Main(new string[] { });
        String output = sb.ToString();


        string expectedOutput = File.ReadAllText("CharacterizationTest.txt");

        Assert.Equal(expectedOutput.Trim(), output.Trim());
    }
}