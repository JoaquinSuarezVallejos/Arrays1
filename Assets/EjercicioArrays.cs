using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArrays : MonoBehaviour
{
    public int[] numeros;
    private int[] otrosNumeros = new int[4];
    public string nombre, invertido;

    void Start()
    {
        ExisteLetraEnCadena(nombre, 'x');
        EscribirCadenaInvertida(nombre);
    }

    void Update()
    {
        
    }
    
    void EscribirLetraPorLetra(string cadena) 
    {
        for (int i = 0; i < cadena.Length; i++) 
        {
            Debug.Log(cadena[i]);
        }
    }

    void EscribirLetraPorLetraMenosLasO(string cadena)
    {
        for (int i = 0; i < cadena.Length; i++) 
        {
            if (cadena[i] != 'o') Debug.Log(cadena[i]);
        }
    }

    void ExisteLetraEnCadena(string cadena, char letraBuscada)
    {
        bool letraEncontrada = false;
        int counter = 0;

        while (!letraEncontrada && counter < cadena.Length)
        {
            if (cadena[counter] == letraBuscada)
            {
                letraEncontrada = true;
                Debug.Log("Existe la letra en la posición " + counter);
            }

            counter++;
        }

        if (counter >= cadena.Length)
        {
            Debug.Log("No existe la letra en la cadena");
        }
    }

    void EscribirCadenaInvertida(string cadena)
    {
        /*int length;
        length = nombre.Length - 1;

        while (length >= 0)
        {
            invertido += nombre[length];
            length--;   
        }

        Debug.Log($"El string invertido es: {invertido}");*/
    }
}
