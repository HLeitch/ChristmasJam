using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GronchCollecting : MonoBehaviour
{
    bool spaceHit = false;
    Present presentCollected;
    PresentHoldPoint presentHolder;
    // Start is called before the first frame update
    void Start()
    {
        presentHolder = GetComponent<PresentHoldPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        spaceHit = Input.GetKey(KeyCode.Space);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Present")
        {
            if (spaceHit)
            {
                Debug.Log("PresentCollected");


                if (collision.TryGetComponent<Present>(out presentCollected)) 
                {
                    collision.enabled = false;
                    presentHolder.HoldPresent(presentCollected);
                }
            }
        }
    }
    void PresentReset()
    {
        presentCollected = null;
        presentHolder.presentNotHeld();
    }

}
