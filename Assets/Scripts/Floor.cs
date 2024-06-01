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
        //让物体朝某一方向以固定速度移动，为了适配不同机器的配置 * Time.deltaTime 让移动更丝滑
        transform.Translate(new Vector3(0,0,1* floorSpeed * Time.deltaTime));
        //transform.Translate(Vector3.forward * floorSpeed * Time.deltaTime);

        if (transform.position.z <= floorLine)
        {
            //用给物体增加向量的方式让物体移动固定距离
            transform.position += Vector3.forward * offset;    //new Vector3(0,0,offset); 
        }
    }
}
