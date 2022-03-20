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

    }
}
