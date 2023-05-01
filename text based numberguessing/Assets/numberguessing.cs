using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class numberguessing : MonoBehaviour
{
    int currentguess;
    int lowestguess = 1;
    int highestguess = 50;
    int count = 0;
    public Text count1;
    public Text gameText;
    // Start is called before the first frame update
    void Start()
        {
        Guess();
        }
    void Guess()
        {
        currentguess = Random.Range(lowestguess, highestguess);
        gameText.text = "Is your number: " + currentguess.ToString();

        }
    // Update is called once per frame
    void Update()
        {/*
        if (Input.GetKeyDown(KeyCode.DownArrow))
            {
            GuessHigher();
            Guess();
            }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
            GuessLower();
            Guess();
            }
        else if (Input.GetKeyDown(KeyCode.Space))
            {
            Correct();
            }
        /*/
        }
        
    public void GuessHigher()
        {
        count++;
        lowestguess = currentguess;
        Guess();
        }
    public void GuessLower()
        {
        count++;
        highestguess = currentguess;
        Guess();
        }
    public void Correct()
        {
        count1.text = "number of guess: " + count.ToString();
        gameText.text = "I got it right! it was " + currentguess.ToString();
        }
    

    }
