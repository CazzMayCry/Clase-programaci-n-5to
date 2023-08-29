using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Nombre { get; set; }

    // Constructor de la clase Animal (no es común en Unity)
    // Se inicializa en Awake() por convención
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
