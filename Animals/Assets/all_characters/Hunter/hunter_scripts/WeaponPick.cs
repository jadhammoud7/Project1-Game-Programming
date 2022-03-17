using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPick : MonoBehaviour
{
    public Transform equipPosition;
    public float distance = 10f;
    public GameObject currentWeapon;
    GameObject wp;
    bool CanGrap;
    int grabbed=0;
    public RectTransform image;
    // Start is called before the first frame update
    void Start()
    {
        image.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        CheckWeapons();
        if(CanGrap){
            if(Input.GetKeyDown(KeyCode.G)){
                if(currentWeapon != null){
                    Drop();
                }
                PickUp();
            }
        }

        if(currentWeapon != null){
            if(Input.GetKeyDown(KeyCode.F)){
                Drop();
            }
        }
    }
    public void CheckWeapons(){
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {
            if(hit.transform.tag == "weapon"){
                //Debug.Log("I can grab it");
                CanGrap = true;
                wp = hit.transform.gameObject;
            }
            else{
                CanGrap = false;
            }
        }
    }

    public void PickUp(){
        currentWeapon = wp;
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
        image.gameObject.SetActive(true);
        grabbed=1;

    }

    public void Drop(){
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon = null;
        grabbed=0;
    }
public int getGrabbed(){
    return grabbed;
}

}
