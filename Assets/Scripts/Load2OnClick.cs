using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Load2OnClick : MonoBehaviour {

    public void LoadScene2(string level)
    {
        
        SceneManager.LoadScene("MiniGameLevel2");
    }
}
