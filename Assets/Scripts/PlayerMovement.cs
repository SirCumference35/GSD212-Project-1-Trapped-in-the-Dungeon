using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{

    public GameObject joyStick;
    public GameObject joyStickBG;
    public Vector2 joyStickVec;
    private Vector2 joyStickTouchPos;
    private Vector2 joyStickOriginalPos;
    private float joyStickRadius;


     void Start()
     {
        joyStickOriginalPos = joyStickBG.transform.position;
        joyStickRadius = joyStickBG.GetComponent<RectTransform>().sizeDelta.y / 4;
        
     }


    public void pointerDown()
    {
        joyStick.transform.position = Input.mousePosition;
        joyStickBG.transform.position = Input.mousePosition;
        joyStickTouchPos = Input.mousePosition;

    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joyStickVec = (dragPos - joyStickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joyStickTouchPos);

        if (joystickDist < joyStickRadius)
        {
            joyStick.transform.position = joyStickTouchPos + joyStickVec * joystickDist;
        }
        else
        {
            joyStick.transform.position = joyStickTouchPos + joyStickVec * joyStickRadius;
        }
    }

    public void PointerUp()
    {
        joyStickVec = Vector2.zero;
        joyStick.transform.position = joyStickOriginalPos;
        joyStickBG.transform.position = joyStickOriginalPos;

    }


}
