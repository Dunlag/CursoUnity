using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    Transform player;
    public GameObject ray;
    public Transform shootPoint;
    public float cadency;
    float timeLastShoot;

    Rigidbody rig;
    EnemyMovement move;
	
	public ParticleSystem particles;

    // Start se llama antes del primer frame
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Obtener una referencia al componente Rigidbody y EnemyMovement en este objeto.
        rig = GetComponent<Rigidbody>();
        move = GetComponent<EnemyMovement>();
    }

    // Update es llamado una vez por cuadro.
    void Update()
    {
        // Si la distancia entre el enemigo y el jugador es menor que 200 unidades...
        if(Vector3.Distance(transform.position, player.position) < 200)
        {
            // Desactivar el movimiento del enemigo y establecer su velocidad a cero.
            move.enabled = false;
            rig.velocity = Vector3.zero;

            // Apuntar al jugador para dispararle
            transform.LookAt(player);

            // Si ha pasado suficiente tiempo desde el último disparo...
            if(Time.time > timeLastShoot + cadency)
            {
				particles.Play();
                // Instanciar un nuevo rayo de disparo en el punto de disparo y rotación especificados.
                Instantiate(ray, shootPoint.position, shootPoint.rotation);
                timeLastShoot = Time.time;
            }
        }
        else
        {
            // Si el jugador está fuera del alcance, volver a activar el movimiento del enemigo.
            move.enabled = true;
        }
    }
}

