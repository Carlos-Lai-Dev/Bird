using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//���������ӿ� ʵ�ֵ����Ļ�����¼�
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
