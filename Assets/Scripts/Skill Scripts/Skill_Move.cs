using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Move : MonoBehaviour
{
    public float speedX = 0f;
    public float speedY = 0f;
    public float speedZ = 0f;

    public bool local = false;

    private void Update()
    {
        if (local)
        {
            transform.Translate(new Vector3(speedX, speedY, speedZ)*Time.deltaTime);
        }
        else
        {
            transform.Translate(new Vector3(speedX, speedY, speedZ) * Time.deltaTime,Space.World);
        }
    }

}
