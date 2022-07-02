using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float tiempo = 9f;

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;

        if (tiempo < 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
