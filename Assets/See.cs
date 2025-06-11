using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class See : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro potText;
    public int protonsAmount;
    public int electronsAmount;
    public int neutronsAmount;
    void Update()
    {
        potText.text = $"CONTENTS\nProtons: {protonsAmount}\nElectrons: {electronsAmount}\nNeutrons: {neutronsAmount}\n";
        Camera[] allCameras = Camera.allCameras;
        Camera closestCam = null;
        float closestDist = float.MaxValue;
        foreach (Camera cam in allCameras)
        {
            if (cam.enabled)
            {
                float dist = Vector3.Distance(transform.position, cam.transform.position);
                if (dist < closestDist)
                {
                    closestDist = dist;
                    closestCam = cam;
                }
            }
        }
        if (closestCam != null)
        {
            transform.LookAt(closestCam.transform);
            transform.Rotate(0, 180, 0);
        }
    }
}
