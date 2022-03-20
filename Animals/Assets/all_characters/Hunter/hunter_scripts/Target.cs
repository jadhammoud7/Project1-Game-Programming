using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [Tooltip("The max health of this animal is 50, and it is fixed.")]
    public int Maxhealth = 50;
    [Tooltip("The current health of the animal, and that will decrease when the animal is shot by a gun.")]
    public int currentHealth = 50;
    [Tooltip("The aim point which is the center of the screen")]
    public RectTransform AimPoint;
    [Tooltip("Damage health for the target enemy")]
    public int damage = 10;
    [Tooltip("Range for damage around the enemy")]
    public int range = 100;
    [Tooltip("Speed of the bullet fire")]
    public int impactForce = 30;
    [Tooltip("The health bar is the script of the health bar which is above the animal")]
    public health_bar health_bar1;
    [Tooltip("The Scriptable Object ammo_amount that container ammo_counter")]
    [SerializeField]
    ammo_amount ammos_amount;
   
    void Update()
    {
        if (Input.GetMouseButton(0))//if left button was pressed
        {
            int ammos_available = ammos_amount.ammo_counter;//gets the number of ammos
            //check if there is ammo
            if (ammos_available > 0)//if the nb of ammo is greater than 0 then he can simply shoot
            {
                RaycastHit hit;//get info about the hit object
                Ray ray = Camera.main.ScreenPointToRay(AimPoint.transform.position);//point the ray towards the centered aim image
                if (Physics.Raycast(ray, out hit, range))//if the ray hits an available hit object
                {
                    if (hit.transform.tag == "Animal")
                    {
                        ammos_amount.ammo_counter--;
                        currentHealth -= damage;
                        health_bar1.setHealth(currentHealth);//set the current health of the animal to be the new value
                        Debug.Log("health of " + gameObject.name + " is now: " + currentHealth);
                        if (currentHealth == 0)//when the health is 0, then the animal dies
                        {
                            Destroy(gameObject);
                        }
                    }
                    if (hit.rigidbody != null)
                    {
                        hit.rigidbody.AddForce(-hit.normal * impactForce);//add force on the rigid body of the target
                    }
                }
            }
            else
            {
                Debug.Log("Out of ammo");
            }
        }
    }
    void Start() {
        currentHealth = Maxhealth;    
    }
}
