// Importando las bibliotecas necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Definiendo la clase EnemyMovement que hereda de MonoBehaviour
public class EnemyMovement : MonoBehaviour
{
    // Declarando campos públicos
    public float speed; // La velocidad del movimiento del enemigo

    // Declarando campos privados
    Vector3 destination; // La posición aleatoria a la que el enemigo se mueve
    Rigidbody rig; // El componente Rigidbody del enemigo para controlar su movimiento

    // Método que establece una nueva posición aleatoria como destino del movimiento del enemigo
    void RamdonDestination()
    {
        destination = new Vector3(
            Random.Range(-1000, 1000),
            Random.Range(-1000, 1000),
            Random.Range(-1000, 1000));
    }

    // Start se llama antes del primer cuadro de actualización
    private void Start() 
    {
        // Obteniendo y asignando el Rigidbody componente al campo rig
        rig = GetComponent<Rigidbody>();

        // Estableciendo un nuevo destino aleatorio para el enemigo
        RamdonDestination();
    }

    // Update se llama una vez por cuadro
// Update se llama una vez por cuadro
void Update()
{
    // Haciendo que el enemigo mire hacia su destino
    transform.LookAt(destination);

    // Asignando la velocidad del movimiento del enemigo hacia adelante multiplicada por la velocidad deseada
    rig.velocity = transform.forward * speed;

    // Si la distancia entre la posición actual del enemigo y su destino es menor que 10 unidades...
    if(Vector3.Distance(transform.position, destination)<10)
    {
        // Estableciendo un nuevo destino aleatorio para el enemigo usando RamdonDestination()
        RamdonDestination();
    }
}

}
