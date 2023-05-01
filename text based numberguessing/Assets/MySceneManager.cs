using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
    { 
    void Start() // Start is called before the first frame update
    { 
        
    }
    void Update()// Update is called once per frame
    {
        
    }
    public void ChangeScene(int _SceneID) //passing parameter
        {
        int x = 2 + _SceneID; //dont know why clarify this?? useless
        SceneManager.LoadScene(_SceneID); //change to the file> build settings> Scene ID
        }}
    
    

    
    
    

