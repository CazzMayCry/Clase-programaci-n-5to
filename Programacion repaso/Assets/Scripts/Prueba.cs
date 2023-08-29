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
    private void Start()
    {
        Nombre = "Perro";
        EmitirSonido("¡Guau guau!");  // Llamar al método directamente
    }

    public override void EmitirSonido(string sonido)
    {
        base.EmitirSonido(sonido);  // Llamar al método de la clase base
        Debug.Log($"{Nombre} ladra: {sonido}");
    }
}
public class Ejemplo : MonoBehaviour
{
    private void Start()
    {
        Perro miPerro = new Perro();
    }
}