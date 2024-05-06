using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadMain()
    {
        Application.LoadLevel("MainGame");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
