using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Tooltip("The particle system of the bullets effect on the top of gun")]
    public ParticleSystem fireFlash;
    [Tooltip("Effect of the bullet on the target, which is a partcile system")]
    public GameObject bullets;
    [Tooltip("The weapon pick script")]
    public WeaponPick weaponPick;

    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && weaponPick.getGrabbed()==1){//if pressed left mouse button
            fireFlash.Play();//play the particle system 
        }
    }
}
