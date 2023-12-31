using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
    public GameObject FirstPersonCam;
    public GameObject TopDownCam;


    private void Start()
    {
        FirstPersonCam.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKey("tab"))
        {
            FirstPersonCam.SetActive(false);
            TopDownCam.SetActive(true);
        }
        else
        {
            FirstPersonCam.SetActive(true);
            TopDownCam.SetActive(false);
        }

    }
}
