using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public static GameManager gameManager = new GameManager(); 

    public  bool isGameOver;

    public  int score;
    //����TextMeshPro ����
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text currentText;
    [SerializeField] private TMP_Text BestText;
    [SerializeField] private GameObject gameOverMenu;
    public void GameOver()
    { 
        isGameOver = true;
        //�����������ʱ����Game Over�˵�����
        gameOverMenu.SetActive(true);
        //����PlayerPrefs�ķ�����������Key����Value����ֵ�����������ô洢
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        //PlayerPrefs.GetFloat("BestScore",0.6f);
        if (score > bestScore)
        { 
            bestScore = score;
            //��ԭ����ֵ���ǣ������봢��������
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
        //��Game OverUI�����ʾ��ȷ�ĵ÷���Ϣ
        currentText.text = "Score: " + score.ToString();
        BestText.text = "BestScore: "+ bestScore.ToString();
        
        Invoke("PoseTime",1f);
        
        
    }
    //���˶���ʱ�侲ֹ
    void PoseTime()
    {
        Time.timeScale = 0f;

    }
    //���õ÷ֲ���
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        
    }
    //���¿�ʼ��Ϸ
    public void Retry()
    {
        //���ض�Ӧ�ĳ���
        SceneManager.LoadScene("GamePlay");
        //���˶�ʱ��ָ�
        Time.timeScale = 1f;
    }
    //�Ƴ���Ϸ
    public void Home()
    {
        Application.Quit();
    }
}
