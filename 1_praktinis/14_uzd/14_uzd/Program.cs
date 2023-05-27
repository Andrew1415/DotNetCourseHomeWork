using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;

enum FlagSize
{
    Micro,
    Small,
    Medium,
    Large
}

public struct Colors
{
    public string name;
    public int count;

    public Colors(string name, int count)
    {
        this.name = name;
        this.count = count;
    }

    public Colors()
    {
        this.name = "Null";
        this.count = -1;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Colors[] colors = new Colors[30];
        readFromFile(colors);
        int numberOfFlags = 0;
        countFlags(colors, out numberOfFlags);
        FlagSize flagSize;
        if (numberOfFlags <= 2)
        {
            flagSize = FlagSize.Micro;
        }
        else if (numberOfFlags <= 5)
        {
            flagSize = FlagSize.Small;
        }
        else if (numberOfFlags <= 10)
        {
            flagSize = FlagSize.Medium;
        }
        else
        {
            flagSize = FlagSize.Large;
        }
        printResults(colors, numberOfFlags, flagSize);
    }


    static void readFromFile(Colors[] colors)
    {
        using (TextReader reader = File.OpenText("colors.txt"))
        {
            int n = int.Parse(reader.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string text = reader.ReadLine();
                string[] bits = text.Split(' ');
                string tempName = bits[0];
                int tempCount = int.Parse(bits[1]);

                string Flag = "True";
                if(i>0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (colors[j].name== tempName && Flag == "True")
                        {
                            colors[j].count += tempCount;
                            Flag = "False";

                        }
                    }
                }
                if(Flag == "True")
                {
                   colors[i] = new Colors(tempName, tempCount);
                    count++;
                }
                
            }
        }

    }

    static void countFlags(Colors[] colors, out int numberOfFlags)
    {
        int min = colors[0].count;
        for (int i = 0;i < colors.Length; i++)
        {
            if (colors[i].count>0 && colors[i].count < min)
            {
                min = colors[i].count;
            }
        }
        numberOfFlags = min / 2;
        for(int i = 0; i < colors.Length; i++)
        {
            if (colors[i].count >= min)
            {
                colors[i].count -= numberOfFlags * 2;
            }
        }
    }

    static void printResults(Colors[] colors, int numberOfFlags, FlagSize flagSize)
    {
        if (File.Exists("flags.txt"))
        {
            File.Delete("flags.txt");
        }
        using (StreamWriter sw = new StreamWriter("flags.txt"))
        {
            sw.WriteLine(numberOfFlags + " " + flagSize.ToString());
            for (int i = 0; i<colors.Length; i++)
            {
                if (colors[i].name != null)
                {
                    sw.WriteLine(colors[i].name + " = " + colors[i].count);
                }
            }
        }
    }
}

