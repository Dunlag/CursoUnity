using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
 public float maxHealth;
    private float currentHealth;
    public Image imageHealth;
    public GameObject particleExplosion;
    // Start is called before the first frame update
    void Start()
    {
         currentHealth = maxHealth;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
         print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("RayPlayer"))
        {
            
            currentHealth--;
            imageHealth.fillAmount = currentHealth / maxHealth;
            if(currentHealth == 0)
            {
                Instantiate(particleExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
