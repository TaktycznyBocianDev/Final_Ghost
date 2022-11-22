using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetBtnBeh : MonoBehaviour
{
   public void GameReset()
    {
        SceneManager.LoadScene(0);
    }
}
