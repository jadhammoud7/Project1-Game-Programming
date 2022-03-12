using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Tooltip("Damage health for the target enemy")]
    public float damage = 10f;
    [Tooltip("Range for damage around the enemy")]
    public float range = 100f;
    [Tooltip("Speed of the bullet fire")]
    public float fireRate = 15f;
    [Tooltip("Force of the bullet on the target")]
    public float impactForce = 30f;
    [Tooltip("First Person Shooter camera")]
    public Camera fpsCam;
    [Tooltip("The particle system of the bullets effect on the top of gun")]
    public ParticleSystem fireFlash;
    [Tooltip("Effect of the bullet on the target, which is a partcile system")]
    public GameObject impactEffect;
    [Tooltip("Seperate time between bullet fire shots")]
    private float nextTimeToFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire){//if pressed left mouse button
            nextTimeToFire = Time.time + 1f/fireRate;//take a break time between one bullet and another
            Shoot();//enter shoot method
        }
    }
    void Shoot()//when shooting
    {
        fireFlash.Play();//play the particle system 
        RaycastHit hit;//get info about the hit object
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null){
                target.TakeDamage(damage);//enter take damage 
            }
            if(hit.rigidbody != null){
                hit.rigidbody.AddForce(- hit.normal * impactForce);//add force on the rigid body of the target
            }
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}
