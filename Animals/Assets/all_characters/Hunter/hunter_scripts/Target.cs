using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [Tooltip("THe max health of this animal is 50.")]
    public float health = 50f;
    public Gradient gradient;
    public Image fill;
     
    
    public Slider slider;
    // public void health_color(){
    //     fill.color=gradient.Evaluate(1f);
    // }

    public void TakeDamage(float amount){
        health -= amount;
        slider.value=health;
        fill.color=gradient.Evaluate(slider.normalizedValue);
        //health_color();
        Debug.Log("health of "+ gameObject.name +" is now: " + health);
        if(health <= 0f){
            Destroy(gameObject);
        }
    }
    //     void Start()
    // {
    //     health_color();
    // }

}
