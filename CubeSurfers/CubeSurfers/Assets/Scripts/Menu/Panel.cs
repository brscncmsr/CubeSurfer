using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace CubeSurfer.Scripts.Menu { 
public class Panel : MonoBehaviour
{ 
       
        Collector collector ;

        private void Awake()
        {
            collector = FindObjectOfType<Collector>();
        }
        public void QuitClick()
    {
        SceneManager.LoadSceneAsync("Menu");
        
        collector.count = 0;
            
    }
    public void EnterClick()
    {
        SceneManager.LoadSceneAsync("Game");
        Time.timeScale = 1f;
        collector.count = 0;

        }
}
}
