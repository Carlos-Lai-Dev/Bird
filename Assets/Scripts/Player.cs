using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator anim;
    [SerializeField] private float jumpForce;
    [SerializeField] private GameObject somke;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;
    //[SerializeField] private AudioClip dead;
    [SerializeField] private AudioClip score;
    [SerializeField] private JoyStick joyStick;
    [SerializeField] private GameObject jumpButton;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (gameManager.isGameOver) return;

        if(joyStick.isHeld)
        //if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = new Vector3(0, 1 * jumpForce, 0);//Vector3.up * jumpForce;
            //���׿���
            joyStick.isHeld = !joyStick.isHeld;
        }
        

        if (rb.velocity.y > 0)
        {
            anim.SetBool("Fly", true);

        }
        else {

            anim.SetBool("Fly", false);

        }

    }


    private void OnTriggerExit(Collider other)
    {
        //�Ա���ײ��������ı�ǩ
        if (other.CompareTag("Tube"))
        {
            //�ӷ�
            gameManager.AddScore();
            //����һ�ε÷�����
            audioSource.PlayOneShot(score);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //audioSource.PlayOneShot(dead);
        gameManager.GameOver();
        //������������
        Instantiate(somke, transform.position, Quaternion.identity);
        Destroy(gameObject);
        jumpButton.SetActive(false);
    }

}
