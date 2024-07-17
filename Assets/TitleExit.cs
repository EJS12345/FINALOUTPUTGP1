using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        // In the editor, stop playing the scene
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        // In the built application, quit the game
        Application.Quit();
#endif
    }
}




