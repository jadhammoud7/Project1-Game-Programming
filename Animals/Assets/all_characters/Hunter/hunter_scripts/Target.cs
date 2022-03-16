using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [Tooltip("THe max health of this animal is 50.")]
    public float Maxhealth = 50f;
    public float currentHealth=0f;
    public health_bar health_bar1;
    void Start()
    {
        currentHealth = Maxhealth;
        health_bar1.setMaxHealth(Maxhealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        health_bar1.setHealth(currentHealth);
        Debug.Log("health of " + gameObject.name + " is now: " + currentHealth);
        if (currentHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }



}
