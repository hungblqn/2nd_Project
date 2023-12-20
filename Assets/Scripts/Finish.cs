using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(0);
            }
            else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
