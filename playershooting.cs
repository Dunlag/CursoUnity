// Importar bibliotecas necesarias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Declarar la clase "playershooting" que hereda de MonoBehaviour
public class playershooting : MonoBehaviour
{
    // Declarar variable pública GameObject llamada "ray"
    public GameObject ray;
    
    // Declarar arreglo de Transform llamado "shootPoint"
    public Transform[] shootPoint;

    // Start se llama antes del primer marco de tiempo
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update se llama una vez por fotograma
    void Update()
    {
        // Si se presiona el botón de disparo (Fire1 en el eje de entrada virtual)
        if (Input.GetButtonDown("Fire1"))
        {
            
            // Para cada punto de disparo
            for(int i = 0; i < 4; i++)
            {
                // Crear un nuevo objeto "ray" en la posición y rotación del punto de disparo
                Instantiate(ray, shootPoint[i].position, shootPoint[i].rotation);
				shootPoint[i].GetChild(0).GetComponent<ParticleSystem>().Play();
                shootPoint[i].GetComponent<AudioSource>().Play();
            }
        }
    }
}
