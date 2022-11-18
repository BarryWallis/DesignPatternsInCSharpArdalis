using System.Text;

using GildedRoseKata;

namespace GildedRoseKataTests;
public class ProgramTests
{
    [Fact]
    public void Program_GeneralTest()
    {
        StringBuilder sb = new();
        Console.SetOut(new StringWriter(sb));
        Program.Main();
        string output = sb.ToString();


        string expectedOutput = File.ReadAllText("CharacterizationTest.txt");

        Assert.Equal(expectedOutput.Trim(), output.Trim());
    }
}
