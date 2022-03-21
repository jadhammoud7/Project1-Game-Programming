using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponPick : MonoBehaviour
{
    [Tooltip("The position where the gun will be put in")]
    public Transform equipPosition;
    [Tooltip("Distance needed to pick up the gun")]
    public float distance = 10f;
    [Tooltip("Current hold weapon, null if not available")]
    public GameObject currentWeapon;
    [Tooltip("Weapon to be picked up")]
    GameObject wp;
    [Tooltip("Check if the weapon can be picked or not")]
    bool CanGrap;
    [Tooltip("Check if the weapon is grabbed or not")]
    int grabbed=0;
    [Tooltip("The aim which is the center of the screen canvas")]
    public RectTransform image;
    [Tooltip("The grab text that tells the player the button to be pressed to pick weapon")]
    public TextMeshProUGUI GrabText;
    [Tooltip("The drop text that tells the player the button to be pressed to drop weapon")]
    public TextMeshProUGUI DropText;
    // Start is called before the first frame update
    void Start()
    {
        image.gameObject.SetActive(false);//the aim is initially inivisible when the user is unarmed
        GrabText.gameObject.SetActive(false);//initially make grab and drop texts invisible 
        DropText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckWeapons();
        if(CanGrap){//if the player is standing near a weapon
            if(Input.GetKeyDown(KeyCode.G)){//when press G button
                if(currentWeapon != null){
                    Drop();//drop the current weapon if the player is holding any
                }
                PickUp();//if the player is unarmed, then pick up a new weapon
            }
        }

        if(currentWeapon != null){//if the user is holding a weapon
            if(Input.GetKeyDown(KeyCode.F)){//if the user pressed button F
                Drop();//drop the current weapon equipped
            }
        }
    }
    public void CheckWeapons(){
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))//create a ray cast forwards with respect to the main camera
        {
            if(hit.transform.tag == "weapon"){
                //Debug.Log("I can grab it");
                CanGrap = true;
                wp = hit.transform.gameObject;
                GrabText.gameObject.SetActive(true);//when the player stands near a weapon, display the grab text
            }
            else{
                CanGrap = false;
                GrabText.gameObject.SetActive(false);
            }
        }
    }

    public void PickUp(){
        currentWeapon = wp;
        currentWeapon.transform.position = equipPosition.position;
        currentWeapon.transform.parent = equipPosition;
        currentWeapon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
        image.gameObject.SetActive(true);//make the aim centered the canvas visible to show how the bullets will be forwarded
        GrabText.gameObject.SetActive(false);//if a weapon was picked up, then make the grab text invisible and the drop text visible
        DropText.gameObject.SetActive(true);
        grabbed=1;//show that the current weapon is grabbed
    }

    public void Drop(){
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        currentWeapon = null;
        grabbed=0;
        DropText.gameObject.SetActive(false);//after dropping, make the drop text invisible
    }
    public int getGrabbed(){
        return grabbed;
    }

}
