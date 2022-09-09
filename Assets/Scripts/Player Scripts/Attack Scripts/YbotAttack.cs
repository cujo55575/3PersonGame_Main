using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YbotAttack : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private GameObject weapon;
    private string ANIMATION_ATTACK = "Attack";

    private Vector3 weaponBackslidePos;
    private Vector3 weaponFrontSlidePos = new Vector3(0.137f, -0.073f, 0.146f);
    private float first_rotX = 345;
    private float first_rotY = 195;
    private float first_rotZ = 257;
    private float second_rotX = 15;
    private float second_rotY = 16;
    private float second_rotZ = 104;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        HandleButtonsPress();
    }
    void HandleButtonsPress()
    {
        if (Input.GetMouseButtonDown(0))
        {

            FlipSword(true);
            anim.SetBool(ANIMATION_ATTACK, true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            FlipSword(false);
            anim.SetBool(ANIMATION_ATTACK, false);
        }
    }
    void FlipSword(bool flipFront)
    {
        if (flipFront)
        {
            Quaternion flip = Quaternion.Euler(second_rotX, second_rotY, second_rotZ);
            weapon.GetComponent<Transform>().localRotation = flip;
            weaponBackslidePos = weapon.GetComponent<Transform>().localPosition;
            weapon.GetComponent<Transform>().localPosition = weaponFrontSlidePos;
        }
        else
        {
            Quaternion flip = Quaternion.Euler(first_rotX, first_rotY, first_rotZ);
            weapon.GetComponent<Transform>().localRotation = flip;
            weapon.GetComponent<Transform>().localPosition = weaponBackslidePos;
        }
    }
}
