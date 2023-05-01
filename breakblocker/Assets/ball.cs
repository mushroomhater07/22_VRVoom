using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rig;
    Vector2 ballstartoffset;
    public GameObject paddleObject;
    // Start is called before the first frame update
    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
        ballstartoffset = transform.position - paddleObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        LockBallToPaddle();
    }
    void Launch(){

        }
    void LockBallToPaddle(){
        Vector2 PaddlePosition = (Vector2)paddleObject.transform.position;
        transform.position = PaddlePosition + ballstartoffset;
        }
}
