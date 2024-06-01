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
        //�任λ�� transform.Translate();  ����������λ�� �������������������
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
