Random rand = new Random();
int heads = 0;
int tails = 0;

for (int i = 0; i < 10000; i++)
{
    int flip = rand.Next(2);
    if (flip == 0)
        heads++;
    else
        tails++;
}

double headsPercentage = (double)heads / 10000 * 100;
double tailsPercentage = (double)tails / 10000 * 100;

Console.WriteLine("Heads: {0}% Tails: {1}%", headsPercentage, tailsPercentage);