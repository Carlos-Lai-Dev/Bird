using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public static GameManager gameManager = new GameManager(); 

    public  bool isGameOver;

    public  int score;
    //声明TextMeshPro 变量
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text currentText;
    [SerializeField] private TMP_Text BestText;
    [SerializeField] private GameObject gameOverMenu;
    public void GameOver()
    { 
        isGameOver = true;
        //死亡条件达成时，将Game Over菜单激活
        gameOverMenu.SetActive(true);
        //调用PlayerPrefs的方法将数据以Key——Value（键值）的形势永久存储
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        //PlayerPrefs.GetFloat("BestScore",0.6f);
        if (score > bestScore)
        { 
            bestScore = score;
            //将原来的值覆盖，并放入储存起来。
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
        //让Game OverUI面板显示正确的得分信息
        currentText.text = "Score: " + score.ToString();
        BestText.text = "BestScore: "+ bestScore.ToString();
        
        Invoke("PoseTime",1f);
        
        
    }
    //将运动的时间静止
    void PoseTime()
    {
        Time.timeScale = 0f;

    }
    //设置得分参数
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        
    }
    //重新开始游戏
    public void Retry()
    {
        //加载对应的场景
        SceneManager.LoadScene("GamePlay");
        //将运动时间恢复
        Time.timeScale = 1f;
    }
    //推出游戏
    public void Home()
    {
        Application.Quit();
    }
}
