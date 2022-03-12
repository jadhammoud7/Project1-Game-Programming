using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunter_house : MonoBehaviour
{
    //[SerializeField] Light turn_off_lights;
    // Start is called before the first frame update
     [SerializeField] 
    Light mylight;

    float light_intensity;
    float first_intensity=70000;
    void Start()
    {
        //mylight=GetComponent<Light>();
        mylight.intensity=400;
        light_intensity=mylight.intensity;//to check the intensity at start

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            Debug.Log("Hunter entered his house");

            Debug.Log("i am sleeping");

             Debug.Log("light intensity is when i am sleeping: "+mylight.intensity);
            StartCoroutine(evening());//starting the function everning by calling it
            }
        }
public void OnTriggerExit(Collider other) {
        Debug.Log("i am awake");
        mylight.intensity=first_intensity;
        StopAllCoroutines();


}
 IEnumerator evening(){
    for(float i=light_intensity;light_intensity>=0;light_intensity-=1f){
        mylight.intensity=light_intensity;
    }
    yield return new WaitForSeconds(1f);//every iteration will take 1 sec
} 
    }


