using System;

namespace PromedioFinal
{
    class Program
    {
        // CONSTANTES
        const double PORC_PARCIALES = 0.55;
        const double PORC_EXAMEN = 0.30;
        const double PORC_TRABAJO = 0.15;

        static void Main(string[] args)
        {
            // VARIABLES
            double p1, p2, p3, p4;
            double promParciales, examen, trabajoF, promFinal;

            // INICIO
            Console.WriteLine("=== Promedio final de Algoritmos ===\n");

            p1 = LeerNota("Parcial 1: ");
            p2 = LeerNota("Parcial 2: ");
            p3 = LeerNota("Parcial 3: ");
            p4 = LeerNota("Parcial 4: ");

            promParciales = ((p1 + p2 + p3 + p4) / 4) * PORC_PARCIALES;

            examen = LeerNota("Examen: ");
            trabajoF = LeerNota("Trabajo final: ");

            promFinal = promParciales + (examen * PORC_EXAMEN) + (trabajoF * PORC_TRABAJO);

            Console.WriteLine($"\nPromedio final: {promFinal:F2}");
            // FIN

            Console.ReadKey();
        }

        // Lee un número y valida que esté entre 0 y 100
        static double LeerNota(string mensaje)
        {
            double nota;
            Console.Write(mensaje);

            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
            {
                Console.Write("Valor inválido. Ingresa un número entre 0 y 100: ");
            }

            return nota;
        }
    }
}