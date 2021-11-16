using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUImanager : MonoBehaviour
{
    public void Onplay(){
        SceneManager.LoadScene ("Main");
    }
    public void Onhelp(){
        SceneManager.LoadScene ("Help");
    }
    public void Oncredit(){
        SceneManager.LoadScene ("Credit");
    }
    public void Onback(){
        SceneManager.LoadScene ("Menu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
