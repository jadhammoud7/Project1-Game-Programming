using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Start is called before the first frame update
    RaycastHit hit;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("I pressed the left button of the mouse");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {


                Cursor.visible = true;
                Debug.Log($"GameObjectName : {hit.collider.gameObject.tag}");

                if (hit.collider.gameObject.tag != "Ground")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
