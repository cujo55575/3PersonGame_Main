using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAttackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private PlayerAttacks playerAttacks;
    private void Awake()
    {
        playerAttacks = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttacks>();
    }
    public void OnPointerDown(PointerEventData data)
    {
        if (gameObject.name == "Attack Button")
            playerAttacks.AttackButtonPressed();
    }
    public void OnPointerUp(PointerEventData data)
    {
        if (gameObject.name == "Attack Button")
            playerAttacks.AttackButtonReleased();
    }
}
