using UnityEngine;
using UnityEngine.SceneManagement;

public class Game1ToEnd1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("End 1");
        }
    }
}