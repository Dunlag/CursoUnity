using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    private float currentHealth;
    public Image imageHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("RayEnemy"))
        {
            
            currentHealth--;
            imageHealth.fillAmount = currentHealth / maxHealth;
        }
    }
}
