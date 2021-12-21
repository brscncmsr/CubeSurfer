using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CubeSurfer.Scripts
{
    public class Collector : MonoBehaviour
    {
        [SerializeField] GameObject MainCube;
        [SerializeField] Collectable collectable;
        [SerializeField] GameObject panel;
        [SerializeField] TextMeshProUGUI scorepanel;
        int height;
        public int count=0;
        int cubeslengt;
        bool anycollect = false;
        void Awake()
        {
            MainCube = GameObject.Find("MainCube");




        }

        // Update is called once per frame
        void Update()
        {

            MainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
            this.transform.localPosition = new Vector3(0, -height, 0);

        }
        public void HeightDecrease()
        {
            height -= 1;
            if (count < 1)
            {
                panel.SetActive(true);
            }
            count =count -1;
            scorepanel.text = "Puan : " + count;

        }
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "Collected" && collision.gameObject.GetComponent<Collectable>().GetColleted() == false)
            {
                height += 1;
                anycollect = true;
                collision.gameObject.GetComponent<Collectable>().makeCollected();
                collision.gameObject.GetComponent<Collectable>().indexSet(height);
                collision.gameObject.transform.parent = MainCube.transform;
                
                if (anycollect)
                {
                    cubeslengt = MainCube.transform.childCount;
                    GameObject[] cubes = new GameObject[15];
                    for (int i = 0; i < cubeslengt; i++)
                    {


                        if (MainCube.transform.GetChild(i).gameObject.tag == "Collected")
                        {
                            cubes[i] = MainCube.transform.GetChild(i).gameObject;
                            cubes[i].gameObject.tag = "Taken";
                            count = count+1;
                            Debug.Log(count);
                            scorepanel.text = "Puan : " + count;




                        }

                    }
                }
            }
        }
    }
}