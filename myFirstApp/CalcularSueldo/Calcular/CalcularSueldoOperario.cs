namespace CalcularSueldo.Calcular
{
    /// <summary>
    /// Este objeto es para calcular los sueldos de los operadores.
    /// </summary>
    public class CalcularSueldoOperario
    {
        /*
             /// <summary>
             /// Calcular el sueldo del operario
             /// </summary>
             /// <param name="horasTrabajadas">las horas trabajadas del empleado</param>
             /// <param name="costoHora">el costo por hora definido en rrhh</param>
            public void Calcular(int horasTrabajadas, int costoHora) 
            {
                // Declaracion de variables //
            }
        */


        public void CalcularSueldo()
        {
            // Declaramos las varibles //
            int horasTrabajadas = 0;
            int costoHora = 0;
            decimal sueldo = 0;
            string linea = string.Empty;
            try
            {
                Console.WriteLine("Ingrese las horas trabajadas: ");
                linea = Console.ReadLine();
                //  horasTrabajadas = int.Parse(Console.ReadLine());

                if (!int.TryParse(linea, out horasTrabajadas))
                {
                   
                    Console.WriteLine($"hora trabajada invalida: { linea }");
                    return;
                }

               // horasTrabajadas = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Ingrese el costo por hora: ");
                costoHora = Convert.ToInt32(Console.ReadLine());

                sueldo = (horasTrabajadas * costoHora);


                Console.WriteLine($"El sueldo es: {sueldo}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} haciendo la operación.");

            }

        }

    }
}
