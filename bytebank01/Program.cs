Console.Clear();

Array amostra  = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.5, 0);
amostra.SetValue(4.1, 1);
amostra.SetValue(10, 2);
amostra.SetValue(33, 3);
amostra.SetValue(22, 4);

TestaMediana(amostra);

void TestaMediana(Array mediana)
{
    if(mediana == null || mediana.Length == 0)
    {
        Console.WriteLine("Array Vazio ou nulo");
    }
    else
    {
        double[] numerosOrdenados = (double[])mediana.Clone();
        Array.Sort(numerosOrdenados);
        int lenght = numerosOrdenados.Length;
        int meio = lenght / 2;
        double medianaCalculada = (lenght % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio-1]) /2;
        Console.WriteLine(medianaCalculada);
    }
}