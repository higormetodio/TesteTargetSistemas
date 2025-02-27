// Texto predefinido
string texto = "Assim como são as pessoas são as criaturas";

// Chamando o método para inverter a string
string textoInvertido = InverterString(texto);

// Exibindo os resultados
Console.WriteLine("Texto: " + texto);
Console.WriteLine("Toxto Invertido: " + textoInvertido);

static string InverterString(string texto)
{
    char[] caracteres = new char[texto.Length];
    int indice = 0;

    for (int i = texto.Length - 1; i >= 0; i--)
    {
        caracteres[indice] = texto[i];
        indice++;
    }

    return new string(caracteres);
}
