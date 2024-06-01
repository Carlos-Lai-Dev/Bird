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
        //简易计时器  累计值 >= 阈值
        time += Time.deltaTime;

        if(time >= spawnTime)
        {
            Spawntube();
            time = 0f;

        }

    }

    private void Spawntube()
    {    
        //生成随机数 Random.Rang(min,max);
        Vector3 tubePosition = new Vector3(transform.position.x, Random.Range(min, max), transform.position.z);
        //生成随机高度的水管
        Instantiate(Tube, tubePosition, Quaternion.identity);
    }

}
