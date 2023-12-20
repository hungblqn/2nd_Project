using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
            ReloadLevel();
        }
    }

    void Die()
    {
        GetComponent<Renderer>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
