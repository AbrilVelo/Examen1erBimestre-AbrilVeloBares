using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // El programa debe cumplir los siguientes requerimientos:
    //    Si se ingresa otra cosa que no sea “D”, “R” o “E” 
    //se debe mostrar el mensaje “Opción de moneda extranjera no válida”.
    //Si la cantidad de dinero de dinero a convertir es menor que 1000,
    //mostrar el mensaje “El monto mínimo es $1000”. 
    //Si los valores ingresados son válidos devolver el mensaje 
    //"[monto a convertir] pesos argentinos equivalen a 
    //[cantidad covertida] [moneda elegida] ". Ejemplo: "1000 pesos equivalen a 3 dólares".

    public float montoPesos;
    public string MonedaExtranjera;

    // dolar: 112,60 peso argentino
    // euro: 122,60 peso argentino
    // reales: 23,87 peso argentino
    void Start()
    {
        float R = montoPesos / 23;
        float D = montoPesos / 112;
        float E = montoPesos / 122;

        if (MonedaExtranjera != "R" && MonedaExtranjera !=  "D" && MonedaExtranjera != "E")
        {
            Debug.Log("Opción de moneda extranjera no válida");
        }
        if (montoPesos < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else if (MonedaExtranjera == "D")
        {
            Debug.Log(montoPesos + " Pesos Argentinos equivalen a " + D + " Dólares");
        }
        else if (MonedaExtranjera == "E")
        {
            Debug.Log(montoPesos + " Pesos Argentinos equivalen a " + E + " Euros");
        }
        else if (MonedaExtranjera == "R")
        {
            Debug.Log(montoPesos + " Pesos Argentinos equivalen a " + R + " Reales");
        }



    }



}

   

