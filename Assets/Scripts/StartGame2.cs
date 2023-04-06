using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame2 : MonoBehaviour
{

    TextMeshProUGUI startButtonText;

    public void StartGameFunction2()
    {
        SceneManager.LoadScene(2);
    }
}
