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
}
