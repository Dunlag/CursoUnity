using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
	public float speedRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed 
		* Input.GetAxis("Vertical") + transform.right * speed 
		* Input.GetAxis("Horizontal");

		transform.Rotate(Vector3.up * speedRot * Input.GetAxis("Mouse X"));
		transform.Rotate(Vector3.right * -speedRot * Input.GetAxis("Mouse Y"));

		Vector3 rot = transform.rotation.eulerAngles;
		rot.z = 0;

		if(rot.x > 80 && rot.x < 180)
			rot.x = 80;

		if(rot.x <280 && rot.x > 180)
			rot.x =280;

		transform.rotation = Quaternion.Euler(rot);
    }
}
