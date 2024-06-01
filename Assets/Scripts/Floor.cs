using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private float floorSpeed;
    [SerializeField] private float floorLine;
    [SerializeField] private float offset;
    //[SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(gameManager.isGameOver) return; 
        //�����峯ĳһ�����Թ̶��ٶ��ƶ���Ϊ�����䲻ͬ���������� * Time.deltaTime ���ƶ���˿��
        transform.Translate(new Vector3(0,0,1* floorSpeed * Time.deltaTime));
        //transform.Translate(Vector3.forward * floorSpeed * Time.deltaTime);

        if (transform.position.z <= floorLine)
        {
            //�ø��������������ķ�ʽ�������ƶ��̶�����
            transform.position += Vector3.forward * offset;    //new Vector3(0,0,offset); 
        }
    }
}
