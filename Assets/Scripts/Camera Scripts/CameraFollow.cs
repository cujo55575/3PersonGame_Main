using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform myTransform;
    private Transform target;
    public Vector3 offset = new Vector3(3f, 7.5f, -3f);
    private void Awake()
    {
        target = GameObject.Find("Ninja").transform;
    }

    private void Start()
    {
        myTransform = this.transform;
    }

    private void Update()
    {
        if (target)
        {
            myTransform.position = target.position + offset;
            myTransform.LookAt(target.position, Vector3.up);
        }
    }

}
