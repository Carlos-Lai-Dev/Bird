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
            //简易开关
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
        //对比碰撞到的物体的标签
        if (other.CompareTag("Tube"))
        {
            //加分
            gameManager.AddScore();
            //播放一次得分音乐
            audioSource.PlayOneShot(score);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //audioSource.PlayOneShot(dead);
        gameManager.GameOver();
        //生成死亡烟雾
        Instantiate(somke, transform.position, Quaternion.identity);
        Destroy(gameObject);
        jumpButton.SetActive(false);
    }

}
