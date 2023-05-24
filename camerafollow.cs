using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player; // capturo la posición de la ardilla
	public Vector3 offset; //distancia inicial enter camara y plaer
	public float smoorhTargetTime; /*el tiempo de retardo de 
									la camara siguiendo al player*/
	Vector3 smoothDampVelocity; // ME OBLIGA UNITY 

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, 
		player.position + offset, ref smoothDampVelocity, smoorhTargetTime);
    }
}
