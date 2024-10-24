using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBasic : MonoBehaviour
{
    public void Story()
    {
        Debug.Log("스토리 버튼");
        SceneManager.LoadScene("Dialouge");
    }
    public void Free()
    {
        Debug.Log("자유 버튼");
        SceneManager.LoadScene("Character Choice");
    }
}
