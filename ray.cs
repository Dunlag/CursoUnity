// Importar bibliotecas necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Declarar la clase "ray" que hereda de MonoBehaviour
public class ray : MonoBehaviour
{
    // Declarar variable pública float llamada "speed"
    public float speed;

    // Start se llama antes del primer marco de tiempo
    void Start()
    {
        // Destruye el objeto después de 3 segundos
        Destroy(gameObject, 3);
    }

    // Update se llama una vez por fotograma
    void Update()
    {
        // Obtiene el componente Rigidbody del objeto y establece su velocidad para moverse hacia delante con la velocidad especificada
        GetComponent<Rigidbody>().velocity = transform.forward *speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        Destroy(gameObject);
    }
}
