using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    [SerializeField]
    ammo_SO this_ammo;

    [SerializeField]
    ammo_amount amount;

    public Ammo_bar ammo_incremting;

    // Start is called before the first frame update
    void Start()
    {
        amount.ammo_counter=3;
        Debug.Log("amount of ammo now is: "+amount.ammo_counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            amount.ammo_counter+=this_ammo.ammo_amount;
            ammo_incremting.setAmountNumber(amount.ammo_counter);
            Debug.Log("amount of ammo now is: "+amount.ammo_counter);
            Destroy(this.gameObject);
         }
        
    }
}