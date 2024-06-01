using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float tubeLine;
    //[SerializeField] private GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        //if (gameManager.isGameOver) return;
        //变换位移 transform.Translate();  给物体增加位移 而不是设置物体的坐标
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.z < tubeLine)
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        //gameManager = FindObjectOfType<GameManager>();
    }
}
