using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePickup : MonoBehaviour
{
    public float range = 20;
    public float throwPower = 10;
    public Transform handTransform;
    [SerializeField]
    private Camera fpsCam;
    private Vector3 rayOrigin;
    private GameObject pickedUpItem = null;

    void Start()
    {
        // fpsCam = Camera.main;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (pickedUpItem == null)
            {
                Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
                RaycastHit hit;
                if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, range))
                {
                    if (hit.collider.GetComponent<IPickup>() != null)
                    {
                        pickedUpItem = hit.collider.gameObject;
                        pickedUpItem.GetComponent<IPickup>().Pickup(handTransform);
                    }
                    
                }
            }
            else
            {
                
                pickedUpItem.GetComponent<IPickup>().Drop(throwPower);
                pickedUpItem = null;
            }
        }
    }
}
