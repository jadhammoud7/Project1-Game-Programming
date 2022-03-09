using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    RaycastHit hit;//included information of collided object
    public RectTransform image;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))//clicked left mouse button
        {
            Debug.Log("Bullet Shot");
            Ray ray = Camera.main.ScreenPointToRay(image.transform.position);//point the ray to the centered image in the canvas

            if (Physics.Raycast(ray, out hit))//if ray hit any object
            {
                Cursor.visible = true;
                Debug.Log("I hitted object of tag: " + hit.collider.gameObject.tag);

                // if (hit.collider.gameObject.tag != "Ground" && hit.collider.gameObject.tag != "Player" && hit.collider.gameObject.tag != "weapon" && hit.collider.gameObject.tag != "Table")//if the mouse was pressed on any object other than player, weapon, table, and terrain
                // {
                //     Destroy(hit.collider.gameObject);
                // }
            }
        }
    }
}
