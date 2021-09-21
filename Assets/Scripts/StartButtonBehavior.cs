using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehavior : MonoBehaviour
{
    public void OnPressStartButton()
    {
        switch (gameObject.name)
        {
            case "Start":
                SceneManager.LoadScene("main");
                break;
            case "Back":
                SceneManager.LoadScene("menu");
                break;
            case "End":
                SceneManager.LoadScene("end");
                break;
            case "Return":
                SceneManager.LoadScene("menu");
                break;

        }
        
    }
}
