using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c1 : MonoBehaviour
    {
    // Start is called before the first frame update
    int Currentguess = 0;
    int Highestguess = 50;
    int Lowestguess = 0;
    void Guess()
        {
        Currentguess = Random.Range(Lowestguess + 1 , Highestguess);
        Debug.Log(Lowestguess.ToString() + Highestguess.ToString());
        Debug.Log("Is your number:" + Currentguess.ToString());
        }
    void Start()
        {
        Debug.Log("Welcome to number gusessing");
        Debug.Log("0 to 50");
        Debug.Log("Up to higher, Down to lower and space for correct");
        Guess();
        }

    // Update is called once per frame
    void Update()
        {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
            Lowestguess = Currentguess;
            Guess();
            }
        if (Input.GetKeyDown(KeyCode.DownArrow))
            {
            Highestguess = Currentguess;
            Guess();
            }
        if (Input.GetKeyDown(KeyCode.Space))
            {
            Debug.Log("I got it right! it was: " + Currentguess.ToString());
            }
        }
    }
