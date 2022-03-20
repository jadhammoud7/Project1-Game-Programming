using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo_script : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,1,0);

    }
    // private void OnTriggerEnter(Collider other) {
    //     if(other.gameObject.tag=="Hunter"){
    //         ammo+=3;
    //         //n3adel el ammo bar;
    //     }
    // }
    // public bool check_ammo(){
    //     return true;
    // }
    // public int getsmg_ammo(){
    //     return ammo;
    // }
    //     public int getAR_ammo(){
    //     return ammo;
    // }
    //     public int getshotgun_ammo(){
    //     return ammo;
    // }


    // //
    //     public void setsmg_ammo(int smg_ammo){
    //     this.ammo=smg_ammo;
    // }
    //     public void setAR_ammo(int AR_ammo){
    //     this.ammo=AR_ammo;
    // }
    //     public void setshotgun_ammo(int shotgun_ammo){
    //     this.ammo=shotgun_ammo;
    // }
}
