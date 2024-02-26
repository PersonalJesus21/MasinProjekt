using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUMANAGER : MonoBehaviour
{
    public void PLAY () 
    {
        SceneManager.LoadScene("GAME");
    }
    public void QUIT () 
    {
        Application.Quit ();
        Debug.Log ("Player has quit");
    }

    
    }

