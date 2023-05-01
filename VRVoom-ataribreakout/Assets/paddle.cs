using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseposition = Input.mousePosition;
        float ratio = mouseposition.x / Screen.width;
        float gamepositionx = ratio * 13f;
        Vector3 newpaddleposition = transform.position;
        newpaddleposition.x = -6.5f + gamepositionx;
        transform.position = newpaddleposition;
    }
}
