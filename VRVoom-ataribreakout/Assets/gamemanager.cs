using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public int brickremaining = 99;
    public int liveremaining = 3;
    public Text bricktext;
    public Text livetext;
    public int score = 0;
    public int highscore = 0;

    public Text scoretext;
    public Text highscoretext;
    public int brickcounter = 0;
    public int multiplier = 1;
    public Text multipliertext;
    // Start is called before the first frame update
    void Start()
    {
        int brickcounter = 0;
        foreach (GameObject obj in FindObjectsOfType<GameObject>())
        {
            if (obj.CompareTag("enemy"))
            {
                brickcounter += 1;
            }
        }
        brickremaining = brickcounter;
        //load highscore
        highscore = PlayerPrefs.GetInt("highscore" + SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        checkbricks();
        bricktext.text = "bricks left: " + brickremaining;
        livetext.text = "lives left: " + liveremaining;
        //if score higher than highscore then replace :)
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore" + SceneManager.GetActiveScene().buildIndex, highscore);
        }

        scoretext.text = "score: " + score;
        highscoretext.text = "high score: " + highscore;
        if(brickcounter >= 5)
        {
            multiplier += 1;
            brickcounter = 0;
        }
        multipliertext.text = "X" + multiplier;
    }
    public void checkbricks()
    {
        if (brickremaining <= 0)
        {
            int currentsceneID = SceneManager.GetActiveScene().buildIndex;
            FindObjectOfType<MySceneManager>().ChangeScene(currentsceneID + 1);
        }
    }
    public void checklives()
    {
        if(liveremaining <= 0)
        {
            FindObjectOfType<MySceneManager>().ChangeScene(0);
        }
    }
}
