using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    Animator anim;
    private void Awake()
    {
        
        anim = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        
    }

    private void OnMouseDrag()
    {
        Debug.Log("mousedown");
        anim.SetBool("Pressed",true);
    }
    private void OnMouseEnter()
    {

    }

    private void OnMouseExit()
    {

    }

    private void OnMouseUpAsButton()
    {
        anim.SetBool("Pressed", false);
    }

}
