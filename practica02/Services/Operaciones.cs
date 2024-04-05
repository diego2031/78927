using System;
using System.Reflection;

namespace WSDL.operaciones
{
    public class Operaciones : Mensajes
    {
        public string Saludar(string nombre)
        {
            string msj = "Hola " + nombre;
            return msj;
        }

        public string Mostrar(string id)
        {
            // Obtenemos todos los métodos de esta clase
            MethodInfo[] methods = typeof(Operaciones).GetMethods(BindingFlags.Public | BindingFlags.Instance);
            
            // Creamos un arreglo para almacenar los nombres de las funciones Saludar
            string[] nombresSaludar = new string[methods.Length];
            int count = 0;

            // Recorremos todos los métodos
            foreach (MethodInfo method in methods)
            {
                // Verificamos si el método se llama "Saludar"
                if (method.Name == "Saludar")
                {
                    // Almacenamos el nombre del método en el arreglo
                    nombresSaludar[count] = method.Name;
                    count++;
                }
            }

            // Mostramos los nombres de las funciones Saludar
            Console.WriteLine("Nombres de las funciones Saludar:");
            foreach (string nombre in nombresSaludar)
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine(nombre);
                }
            }

            return "x"; // Suponiendo que querías retornar algo más aquí
        }
    }
}
