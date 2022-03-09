using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount){
        health -= amount;
        Debug.Log("health of "+ gameObject.name +" is now: " + health);
        if(health <= 0f){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
        Debug.Log(gameObject.name + " has died");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
