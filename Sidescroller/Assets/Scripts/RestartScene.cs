using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    public GameObject gameObject;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.name.Equals(gameObject.name))
        {
            ResetScene();
        }

    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
