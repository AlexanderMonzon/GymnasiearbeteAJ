using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{
    TextMeshProUGUI restartButtonText;
    public void RestartGameFunction()
    {
        SceneManager.LoadScene(0);
    }
}
