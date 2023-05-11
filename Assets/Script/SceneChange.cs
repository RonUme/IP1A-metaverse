using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("LoadScene", 2.0f);
        }
    }

    void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Outside1");
    }
}
