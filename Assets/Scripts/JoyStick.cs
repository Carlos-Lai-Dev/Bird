using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//引入两个接口 实现点击屏幕触发事件
public class JoyStick : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [HideInInspector] public bool isHeld;

    public void OnPointerDown(PointerEventData eventData)
    {
       isHeld = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld= false;
    }

    
}
