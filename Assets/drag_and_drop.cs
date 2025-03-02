using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_and_drop : MonoBehaviour
{
    Vector3 mousePosition;
    private Vector3 GetMousePos(){
	    return Camera.main.WorldToScreenPoint(transform.position);
    }


    private void OnMouseDown(){
	    mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag(){
	    transform.position  = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("SubAtomic")){
            Debug.Log("Subatomic collision");
        }

    }

}
