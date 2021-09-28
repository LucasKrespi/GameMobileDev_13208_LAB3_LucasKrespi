using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rect screen;
    public Rect screenSafeArea;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rect ScreenRect = new Rect(0.0f, 0.0f, Screen.width, Screen.height);
        screen = ScreenRect;
        screenSafeArea = Screen.safeArea;

        CheckOrientation();
    }

    private static void CheckOrientation()
    {
        switch (Screen.orientation)
        {
            case ScreenOrientation.LandscapeRight:
                break;
            case ScreenOrientation.LandscapeLeft:
                break;
            case ScreenOrientation.Portrait:
                break;
            default:
                break;
        }
    }
}
