// Importando las bibliotecas necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definiendo la clase RockSpwaner que hereda de MonoBehaviour
public class RockSpwaner : MonoBehaviour
{
    // Declarando un campo público para almacenar una matriz de GameObjects para rocas
    public GameObject[] rock;
    
    // Start se llama antes del primer cuadro de actualización
    void Start()
    {
        // Generando 200 rocas dentro del rango especificado con rotación y escala aleatorias
        for (int i = 0; i < 200; i++)
        {
            // Vector de posición aleatorio dentro de (-1000, -1000, -1000) a (1000, 1000, 1000)
            Vector3 position = new Vector3(
                Random.Range(-1000, 1000),
                Random.Range(-1000, 1000),
                Random.Range(-1000, 1000));
            
            // Rotación aleatoria en los ejes x, y y z
            Quaternion rotation = Quaternion.Euler(
                Random.Range(0, 360),
                Random.Range(0, 360),
                Random.Range(0, 360));

            // Índice aleatorio para seleccionar una roca de la matriz de rocas
            int random = Random.Range(0, rock.Length);

            // Instanciando una nueva roca GameObject en la posición, rotación y escala especificada
            GameObject newRock = Instantiate(rock[random], position, rotation, transform);

            // Escalado aleatorio de la nueva roca
            newRock.transform.localScale = new Vector3(
                Random.Range(10, 50),
                Random.Range(10, 50),
                Random.Range(10, 50));
        }
    }

    // Update se llama una vez por cuadro
    void Update()
    {
        
    }
}
