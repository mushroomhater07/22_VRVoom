using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splitter : MonoBehaviour
{
    bool istrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        }
    public void splitball(GameObject _ballcopy, int splitamount)
    {
        float currentspeed = _ballcopy.GetComponent<Rigidbody2D>().velocity.magnitude;
        for (int i = 0; i < splitamount; i++)
        {
            GameObject newball = Instantiate(_ballcopy, _ballcopy.transform.position, Quaternion.identity);
            float randomx = Random.Range(-1f, 1f);
            float randomy = Random.Range(-1f, 1f);
            newball.GetComponent<Rigidbody2D>().velocity = new Vector2(randomx, randomy).normalized * currentspeed;

            newball.GetComponent<ball>().hasballlaunched = true;
            newball.GetComponent<ball>().ballstartoffset = _ballcopy.GetComponent<ball>().ballstartoffset; 
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<ball>()!= null && istrigger == false)
        {
            istrigger = true;
            splitball(collision.gameObject, 2);
            Destroy(this.gameObject);
        }
    }

}
