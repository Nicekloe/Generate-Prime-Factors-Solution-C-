using Ch04Ex02PrimeFactorsLib;


Write("Enter a positive number between 1 and 1000: ");
string? input = ReadLine();

if (int.TryParse(input, out int result))
{
    WriteLine($"The prime factors of {result} are: {PrimeFactors.PrimeFactorsGenerate(result)}");
}
else
{

}


