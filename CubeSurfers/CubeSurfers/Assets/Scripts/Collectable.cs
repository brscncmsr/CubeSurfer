using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CubeSurfer.Scripts
{
    public class Collectable : MonoBehaviour
    {
        bool isCollected;
        int index;
        [SerializeField] Collector collector;

        private void Awake()
        {
            collector = FindObjectOfType<Collector>();
        }
        void Start()
        {
            isCollected = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (isCollected == true)
            {
                if (transform.parent != null)
                {
                    transform.localPosition = new Vector3(0, -index, 0);
                }
            }


        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Block")
            {
                collector.HeightDecrease();
                transform.parent = null;
                GetComponent<BoxCollider>().enabled = false;
                if (GetComponent<BoxCollider>().enabled == false)
                {
                    Destroy(gameObject);
                }
                other.gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
        public bool GetColleted()
        {
            return isCollected;
        }

        internal void makeCollected()
        {
            isCollected = true;
        }

        public void indexSet(int index)
        {
            this.index = index;
        }
    }
}
