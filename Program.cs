









  string [] mass = {"this", "is", "gonna", "be", "fun", "!"};

string [] mass2 = new string [1];

for (int i = 0; i < mass.Length; i++)
{
    for (int j = 0; j < mass2.Length; j++)
    {
        if  (mass[i].Length <= 3)
        {
            mass2[j] = mass[i];
             Console.Write(mass2[j]+" ");
        }
    }
}
 







