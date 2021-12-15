using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GronchCollecting : MonoBehaviour
{
    bool spaceHit = false;


    // Start is called before the first frame update
    void Start()
    {
        
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
            if(spaceHit)
            {
                Debug.Log("PresentCollected");
            }
        }
    }
}
