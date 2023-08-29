using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Nombre { get; set; }

    private void Awake()
    {
        Nombre = "Animal";
    }

    public virtual void EmitirSonido(string sonido)
    {
        Debug.Log($"{Nombre} emite el sonido: {sonido}");
    }
}

public class Perro : Animal
{
    // Método que se ejecuta al inicio (parte de la herencia)
    private void Start()
    {
        Nombre = "Perro";
    }

    // Polimorfismo: Sobrescribir el método EmitirSonido
    public override void EmitirSonido(string sonido)
    {
        Debug.Log($"{Nombre} ladra: {sonido}");
    }
}

public class Ejemplo : MonoBehaviour
{
    private void Start()
    {
        // Crear una instancia de Perro (uso del constructor)
        Perro miPerro = new Perro();

        // Llamar al método EmitirSonido utilizando polimorfismo
        miPerro.EmitirSonido("¡Guau guau!");  // Uso del método y el parámetro
    }
}
