using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ball : MonoBehaviour
{
    Rigidbody2D rig;
    public Vector2 ballstartoffset;
    public GameObject paddleobject;
    public bool hasballlaunched = false;
    public AudioClip[] bouncesoundeffect;
    public AudioClip[] breaksoundeffect;
    public GameObject particleeffect;

    public GameObject powerup;
    public float powerupchance = 0f;
    // Start is called before the first frame update
    void Start()
    {

        rig = gameObject.GetComponent<Rigidbody2D>();
        if (ballstartoffset == Vector2.zero)
        {
            ballstartoffset = transform.position - paddleobject.transform.position;
        }
    }
    private void launch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = new Vector2(1f, 10f);
            hasballlaunched = true;
        }
    }
    void lockballtopaddle()
    {
        Vector2 paddleposition = (Vector2)paddleobject.transform.position;
        transform.position = paddleposition + ballstartoffset;
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            float randomchance = Random.Range(0f, 1f);
            if (randomchance < powerupchance)
            {
                GameObject newobj = Instantiate(powerup, collision.transform.position, Quaternion.identity);
            }
            //set score 
            FindObjectOfType<gamemanager>().score += 10 * FindObjectOfType<gamemanager>().multiplier;
            //set multiplier
            FindObjectOfType<gamemanager>().brickcounter += 1;

            int randomindex = Random.Range(0, breaksoundeffect.Length);
            AudioSource.PlayClipAtPoint(breaksoundeffect[randomindex], Camera.main.transform.position);
            Instantiate(particleeffect, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject, 0.1f);
            FindObjectOfType<gamemanager>().brickremaining -= 1;
            FindObjectOfType<gamemanager>().checkbricks();
        }
        else { 
            int randomindex = Random.Range(0, bouncesoundeffect.Length);
            AudioSource.PlayClipAtPoint(bouncesoundeffect[randomindex], Camera.main.transform.position);
        }
        
    }
    // Update is called once per frame
    void Update() 
    {
        if (hasballlaunched == false)
        {
            lockballtopaddle();
            launch();
        }
        
    }
    

}
