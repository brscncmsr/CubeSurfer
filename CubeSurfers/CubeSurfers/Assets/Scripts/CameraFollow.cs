using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CubeSurfer.Scripts { 
public class CameraFollow : MonoBehaviour
{
    public GameObject aim;
    public Vector3 distance;
    public float FollowSpeed = 0.25f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, aim.transform.position+ distance,Time.deltaTime);
    }
}
}