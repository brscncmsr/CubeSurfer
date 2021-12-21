using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CubeSurfer.Scripts
{
    public class FinishTrigger : MonoBehaviour
    {
        [SerializeField] GameObject panel;
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}

