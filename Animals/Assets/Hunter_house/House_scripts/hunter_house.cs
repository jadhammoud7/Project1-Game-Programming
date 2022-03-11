using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunter_house : MonoBehaviour
{
    //[SerializeField] Light turn_off_lights;
    // Start is called before the first frame update
    [SerializeField] Light mylight;
    float constant_light_intensity;
    float light_intensity;
    void Start()
    {
        light_intensity=mylight.intensity;//to check the intensity at start
        constant_light_intensity=mylight.intensity;//to save the intensity at start so that when hunters get awake the 
        //sun will shine
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
            //turn_off_lights.enabled=false;
            StartCoroutine(evening());
            }
        }
public void OnTriggerExit(Collider other) {
        //other.gameObject.SetActive(true);
        Debug.Log("i am awake");
        //turn_off_lights.enabled=true;
        StopCoroutine(evening());
          mylight.intensity=  constant_light_intensity;

}
 IEnumerator evening(){
        for(float i=light_intensity;light_intensity>=0;light_intensity-=1f){
            mylight.intensity=light_intensity;;
    }
    yield return null;
} 
    }


