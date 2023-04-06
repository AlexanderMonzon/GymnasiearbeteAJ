using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame3 : MonoBehaviour
{

    TextMeshProUGUI startButtonText;

    public void StartGameFunction3()
    {
        SceneManager.LoadScene(3);
    }
}
