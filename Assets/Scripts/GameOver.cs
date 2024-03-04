using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Enemigo")
        {
            SceneManager.LoadScene(1);
        }
    }

    public void RestartGame()
    {

     SceneManager.LoadScene(0);

    }
}
