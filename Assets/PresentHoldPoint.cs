using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentHoldPoint : MonoBehaviour
{

    public Transform holdPoint;
    public bool presentHeld;
    public Present present;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(presentHeld)
        {
            present.transform.position = this.holdPoint.position;

        }
    }

    public void presentNotHeld()
    {
        present = null;
        presentHeld = false;
    }
    public void HoldPresent(Present present)
    {
        presentHeld = true;
        this.present = present;
    }
}
