using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    public float backgroungSpeed;
    public Renderer backgroundRenderer;
   
    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroungSpeed * Time.deltaTime,0f);    
    }
}
