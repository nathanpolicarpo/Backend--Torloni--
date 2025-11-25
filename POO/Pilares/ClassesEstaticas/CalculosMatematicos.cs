

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // operações Matematica simples
        // visibilidade tipoDeRetorno Nome (parametros) {Corpos}
        public static float Somar (float a, float b)
        {
        return a + b;
        } 
    
    public static float Subtrair (float a, float b)
        {
        return a - b;
        }

    public static float Multiplicar (float a, float b)
        {
        return a * b;
        }

    public static float Dividir (float a, float b)
    {
    if (b == 0)
            {
                Console.WriteLine("Impossivel realizar divisao por 0...");
                return 0;
            }
        return a / b;
    }

    }
}