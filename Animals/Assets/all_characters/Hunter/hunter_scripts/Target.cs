using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [Tooltip("THe max health of this animal is 50.")]
    public float Maxhealth = 50f;
    public float currentHealth=50f;
    public health_bar health_bar1;
    
    void Start()
    {
        //health_bar1.setMaxHealth(Maxhealth);
    }

    public void TakeDamage(float amount)
    {
        Debug.Log(gameObject.tag);
        currentHealth -= amount;
        health_bar1.setHealth(currentHealth);//0
        Debug.Log("health of " + gameObject.name + " is now: " + currentHealth);//-70
        if (currentHealth == 0f)
        {
            Destroy(gameObject);
        }
    }



}
