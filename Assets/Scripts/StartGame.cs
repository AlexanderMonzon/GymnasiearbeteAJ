using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    TextMeshProUGUI startButtonText;

    public void StartGameFunction1()
    {
        SceneManager.LoadScene(1);
    }
}
