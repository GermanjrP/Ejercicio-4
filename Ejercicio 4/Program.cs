using System;

namespace ejercicio4
{
    class Program
    {
        static double CalcularPromedio(double[] calificaciones, int n)
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += calificaciones[i];
            }
            return suma / n;
        }

        static string EvaluarAprobacion(double promedio)
        {
            if (promedio <= 6)
            {
                return "Reprobado";
            }
            else
            {
                return "Aprobado";
            }
        }

        static void Principal()
        {
            int i, j, n;
            double suma, promedio;
            string nombre, matricula, resultado;
            string[] materias = new string[5];
            double[] notas = new double[100];
            double[] promedioMaterias = new double[5];
            string[] resultadoMaterias = new string[5];

            materias[0] = "Sociales";
            materias[1] = "Matemáticas";
            materias[2] = "Biologia";
            materias[3] = "Quimica";
            materias[4] = "Informatica";

            Console.Write("Nombre del estudiante: ");
            nombre = Console.ReadLine();

            Console.Write("Matrícula: ");
            matricula = Console.ReadLine();

            Console.Write("Ponga el número de calificaciones por materia: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("=== " + materias[i] + " ===");
                for (j = 0; j < n; j++)
                {
                    Console.Write("Ingrese la nota " + (j + 1) + ": ");
                    notas[j] = double.Parse(Console.ReadLine());
                }

                promedioMaterias[i] = CalcularPromedio(notas, n);

                if (promedioMaterias[i] <= 6)
                {
                    resultadoMaterias[i] = "Reprobado";
                }
                else
                {
                    resultadoMaterias[i] = "Aprobado";
                }
            }

            promedio = CalcularPromedio(promedioMaterias, 5);

            resultado = EvaluarAprobacion(promedio);

            Console.WriteLine("");
            Console.WriteLine("===== Sabana de Calificaciones =====");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Materia: " + materias[i]);
                Console.WriteLine("Promedio: " + promedioMaterias[i]);
                Console.WriteLine("Resultado: " + resultadoMaterias[i]);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("");
            Console.WriteLine("Promedio general: " + promedio);
            Console.WriteLine("El estudiante ha " + resultado);
        }

        static void Main(string[] args)
        {
            Principal();
        }
    }

}