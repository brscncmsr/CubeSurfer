using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace CubeSurfer.Scripts.Menu { 
public class MainMenu : MonoBehaviour
{
    
        public void QuitClick()
        {
        Application.Quit();
        }
        public void EnterClick()
        {
        SceneManager.LoadSceneAsync("Game");
            Time.timeScale = 1f;
        }
    }
}
