using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{

    public void LoadScene(string level)
    {
        //Application.LoadLevel("MiniGame");
         SceneManager.LoadScene("MiniGame");
    }
}