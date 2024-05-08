using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayAgainScene", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAgainScene()
    {
        Application.LoadLevel("PlayAgain");
    }
}
