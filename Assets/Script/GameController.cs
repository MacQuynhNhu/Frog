using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float spawnTime;
    float m_spawnTime;
    public GameObject ball;
    int score = 0;
    bool isGameover;
    UIManager uiManager;
    string textScore;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        uiManager = FindObjectOfType<UIManager>();
        textScore = uiManager.TextScore.text;
    }

    // Update is called once per frame
    public void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if(isGameover)
        {
            uiManager.ShowGameoverPanel(true);
            return;
        }
        if(m_spawnTime <= 0)
        {
            CreateDrag();
            
            m_spawnTime = spawnTime;
        }
    }

    public int Score
    {
        get => score;
        set {
            score = value;
        }
    }
    public void IncreaseScore()
    {
        score++;
        uiManager.SetTextScore(textScore+score.ToString());
    }
    public bool IsGameover
    {
        get => isGameover;
        set { isGameover = value; }
    }

    public void CreateDrag()
    {
        Vector2 v = new Vector2(Random.Range(-7, 7), 6);
        if (ball)
        {
            Instantiate(ball, v, Quaternion.identity);
        }
    }

    public void Replay()
    {
        uiManager.ShowGameoverPanel(false);
        uiManager.SetTextScore(textScore + " 0");
        isGameover = false;
        score = 0;
    }
   
}
