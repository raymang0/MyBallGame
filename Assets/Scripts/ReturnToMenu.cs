using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {

    public void LoadMenu1(string level)
    {

        SceneManager.LoadScene("MainMenu");
    }
}
