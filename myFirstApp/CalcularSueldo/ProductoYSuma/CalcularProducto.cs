

using CalcularSueldo.Calcular;

namespace CalcularSueldo.ProductoYSuma
{
    /// <summary>
    /// Calcular el producto y la suma de dos números
    /// </summary>
    public class CalcularProducto
    {
        /// <summary>
        /// Mostrar la suma y el producto a partir de dos números.
        /// </summary>
        public void Calcular()
        {
            // Declarar las variables //


            int num1 = 0;
            int num2 = 0;
            int producto = 0;
            int suma = 0;
            string linea = null;
            bool? result = null;
            CalcularSueldoOperario calcularSueldoOperario1 = null;

            try
            {
                //Pedir los números por teclado //
                Console.WriteLine("Ingrese el valor del num 1: ");
                linea = Console.ReadLine();


                // Validar el tipo de datos //
                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("El num 1 es inválido.");
                    return;
                }


                Console.WriteLine("Ingrese el valor del num2: ");
                linea = Console.ReadLine();


                // Validar el tipo de datos //
                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("El num 1 es inválido.");
                    return;
                }

                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"La suma es: {suma}  y el producto es: {producto}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: {ex.Message} realizando la operación");
            }

        }
    }

}
