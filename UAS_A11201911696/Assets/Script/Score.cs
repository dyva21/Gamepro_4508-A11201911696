using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")!=null)
        {
            
            SaveLoadHighscore.SaveHighscore ((int)score);
            score += 1*Time.deltaTime;
            scoreText.text =((int)score).ToString();
            
            if (score >= 10) 
                GUIManager.saveLevel (1);
            if (score >= 20) 
                GUIManager.saveLevel (2);
        }
        
    }
}
