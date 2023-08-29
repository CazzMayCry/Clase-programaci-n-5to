using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Nombre { get; set; }

    // Constructor de la clase Animal (inicialización en Awake)
    private void Awake()
    {
        Nombre = "Animal";
    }

    // Método que utiliza un parámetro
    public void EmitirSonido(string sonido)
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

