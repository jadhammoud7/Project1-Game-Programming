using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo_script : MonoBehaviour
{
    public int smg_ammo=3;
    public int AR_ammo=3;
    public int shotgun_ammo=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,1,0);

    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="smg_ammo" || other.gameObject.tag=="AR_ammo" || other.gameObject.tag=="shotgun_ammo"){
            smg_ammo+=3;
            AR_ammo+=3;
            shotgun_ammo+=3;
        }
    }
    public bool check_ammo(){
        return true;
    }
    public int getsmg_ammo(){
        return smg_ammo;
    }
        public int getAR_ammo(){
        return AR_ammo;
    }
        public int getshotgun_ammo(){
        return shotgun_ammo;
    }
}
