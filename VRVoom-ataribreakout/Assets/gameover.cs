using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FindObjectsOfType<ball>().Length <= 1)
        {
            FindObjectOfType<gamemanager>().liveremaining -= 1;
            FindObjectOfType<gamemanager>().checklives();
            collision.gameObject.GetComponent<ball>().hasballlaunched = false;
            //reset multiplier
            // gamemanager temp == Findobejectoftype<gamemanager>().multipler = 1
            gamemanager tempmanager = FindObjectOfType<gamemanager>();
            tempmanager.multiplier = 1;
            tempmanager.brickcounter = 0;
                
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
