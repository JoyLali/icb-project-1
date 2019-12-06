using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadinggame : MonoBehaviour
{
     private void TitleScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
