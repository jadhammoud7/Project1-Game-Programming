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
    [Tooltip("This is the audio of the gun")]
    AudioSource myAudioSource;

    void Start(){
        myAudioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && HoldingGun()){//if pressed left mouse button
            fireFlash.Play();//play the particle system 
            myAudioSource.Play();
        }
    }
    public bool HoldingGun(){
        if(weaponPick.getGrabbed()==1)
            return true;
        return false;
    }
}
