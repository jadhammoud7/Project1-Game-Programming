using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    [Tooltip("The Scriptable Object ammo_SO that contains ammo_amount")]
    [SerializeField]
    ammo_SO this_ammo;

    [Tooltip("The Scriptable Object ammo_amount that container ammo_counter")]
    [SerializeField]
    ammo_amount amount;

    [Tooltip("This script is responsible for the movement of slider and color of the ammo bar")]
    public Ammo_bar ammo_incremting;

    // Start is called before the first frame update
    void Start()
    {
        ammo_incremting.setAmountNumber();//initially start with only 3 ammos
        Debug.Log("amount of ammo now is: "+ ammo_incremting.getNumber_of_Ammo());
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            amount.ammo_counter += this_ammo.ammo_amount;
            ammo_incremting.setAmountNumber();
            Debug.Log("amount of ammo now is: "+amount.ammo_counter);
            Destroy(this.gameObject);
        }   
    }
}
