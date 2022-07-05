using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaImg : MonoBehaviour
{
    public Image

            card1,
            card2,
            card3;

    public Image imgBarco;

    public void Correcto()
    {
        SceneManager.LoadScene(1);
    }

    public void Correcto2()
    {
        SceneManager.LoadScene(4);
    }

    public void Error()
    {
        SceneManager.LoadScene(2);
    }

    public void Error2()
    {
        SceneManager.LoadScene(5);
    }

    public void JugarAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void JugarAgain2()
    {
        SceneManager.LoadScene(3);
    }

    public void ErrorSuma()
    {
        SceneManager.LoadScene(7);
    }

    public void JugarAgainSuma()
    {
        SceneManager.LoadScene(6);
    }

    public void Winsuma()
    {
        SceneManager.LoadScene(8);
    }

    public void JugarResta()
    {
        SceneManager.LoadScene(9);
    }

     public void ErroResta()
    {
        SceneManager.LoadScene(10);
    }

    public void JugarAgainResta()
    {
        SceneManager.LoadScene(9);
    }

    public void Winresta()
    {
        SceneManager.LoadScene(11);
    }

    public void JugarError()
    {
        SceneManager.LoadScene(12);
    }

    public void ErroError()
    {
        SceneManager.LoadScene(14);
    }

    public void JugarAgainError()
    {
        SceneManager.LoadScene(12);
    }

    public void WinError()
    {
        SceneManager.LoadScene(13);
    }
}
