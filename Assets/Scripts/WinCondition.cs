using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        SpelunkerController player = other.gameObject.GetComponent<SpelunkerController>();

        if (player != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
