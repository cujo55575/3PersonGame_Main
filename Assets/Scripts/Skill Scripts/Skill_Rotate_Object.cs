using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Rotate_Object : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;

    private void Update()
    {
        transform.Rotate(new Vector3(x,y,x)*Time.deltaTime);
    }
}
