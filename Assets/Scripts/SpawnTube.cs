using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTube : MonoBehaviour
{
    [SerializeField] private GameObject Tube;
    [SerializeField] private float min;
    [SerializeField] private float max;
    [SerializeField] private float spawnTime;
    //[SerializeField] private GameManager gameManager;
    float time = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameManager.isGameOver) return;
        //���׼�ʱ��  �ۼ�ֵ >= ��ֵ
        time += Time.deltaTime;

        if(time >= spawnTime)
        {
            Spawntube();
            time = 0f;

        }

    }

    private void Spawntube()
    {    
        //��������� Random.Rang(min,max);
        Vector3 tubePosition = new Vector3(transform.position.x, Random.Range(min, max), transform.position.z);
        //��������߶ȵ�ˮ��
        Instantiate(Tube, tubePosition, Quaternion.identity);
    }

}
