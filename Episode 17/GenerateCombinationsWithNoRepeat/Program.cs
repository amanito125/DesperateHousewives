using System.Xml.Linq;

static void Generate(int index, int start)

{

    if (index >= k)
    {

        Console.WriteLine(string.Join(" ", combination));
    }
    else
    {

        for (int i = start; i < elements.Length; i++)
        {

            combination[index] = elements[i];

            Generate(index + 1, i+1);

        }

    }

}