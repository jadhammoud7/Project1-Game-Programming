using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hunter_script : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.anyKey){
			animator.SetBool("is_moving", true);
		}
		else{
			animator.SetBool("is_moving", false);
		}
     		// 	//checking if is moving
			// float horizontalInput=Input.GetAxis("Horizontal");
			// float VerticalInput=Input.GetAxis("Vertical");
			// Vector3 movementDirection=new Vector3(horizontalInput,0,VerticalInput);
			// float magnitude=Mathf.Clamp01(movementDirection.magnitude);
			// Vector3 velocity=movementDirection*magnitude;
			// if(movementDirection!=Vector3.zero){
			// 	animator.SetBool("is_moving",true);
			// }else{
			// 	animator.SetBool("is_moving",false);
			// }   
    }
}
