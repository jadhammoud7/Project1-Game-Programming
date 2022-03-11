using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunter_house : MonoBehaviour
{
    [SerializeField] Light turn_off_lights;
    // Start is called before the first frame update
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            Debug.Log("Hunter entered his house");
            //other.gameObject.SetActive(false);
            Debug.Log("i am sleeping");
            turn_off_lights.enabled=false;
            }
        }
public void OnTriggerExit(Collider other) {
        //other.gameObject.SetActive(true);
        Debug.Log("i am awake");
        turn_off_lights.enabled=true;
}
    }

