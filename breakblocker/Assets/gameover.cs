using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
        FindObjectOfType<MySceneManager>().ChangeScene(0);

        }
    }
