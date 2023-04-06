using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public GameObject Player;
    public TextMeshProUGUI ScoreText;
    PlayerController playerController;
    public float ScoreCount;
    public double ScoreCountToAdd;
    public double ScoreGoal;

    void Start()
    {
        ScoreCount= 0;
    }

    private void Update()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        ScoreCount += Time.deltaTime;
        ScoreCountToAdd = System.Math.Round(ScoreCount);

        if (playerController.playerHealth > 0)
        {
            ScoreText.text = "Score: " + ScoreCountToAdd;
        }

        if (ScoreCountToAdd == ScoreGoal)
        {
            SceneManager.LoadScene(5);
        }
    }
}
