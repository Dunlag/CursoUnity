using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearclones : MonoBehaviour
{
    public GameObject prefab;
    //aqui indico la posición donde quiero que aparezcan los clones del prefab
    public Transform transformPrefab;
    public float thrust; //fuerza de empuje
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            crearObjetos();
        }
    }

    //Creamos los clones del prefab(ciervos)
    void crearObjetos()
    {
        GameObject clones = Instantiate (prefab, transformPrefab.position, transformPrefab.rotation);
        //Necesito usar rigibody de mis ciervos
        Rigidbody rbPrefab = clones.GetComponent<Rigidbody>();
        //vamos a destruir los clones pasados unos segundos
        Destroy(clones, 5);
        //da una fuerza hacia arriba 
        rbPrefab.AddForce(Vector3.up * 1000);
        rbPrefab.AddForce(Vector3.forward * thrust);
    }
}
