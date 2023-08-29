using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    class Animal
    {
        public string Nombre { get; set; }

        // Constructor de la clase Animal
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método que utiliza un parámetro
        public void EmitirSonido(string sonido)
        {
            Console.WriteLine($"{Nombre} emite el sonido: {sonido}");
        }
    }

    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        // Polimorfismo: Sobrescribir el método EmitirSonido
        public override void EmitirSonido(string sonido)
        {
            Console.WriteLine($"{Nombre} ladra: {sonido}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Crear una instancia de Perro
            Perro miPerro = new Perro("Max");

            // Llamar al método EmitirSonido utilizando polimorfismo
            miPerro.EmitirSonido("¡Guau guau!");
        }
    }
    
}
