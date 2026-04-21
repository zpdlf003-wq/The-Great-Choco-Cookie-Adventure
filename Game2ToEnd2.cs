using UnityEngine;
using UnityEngine.SceneManagement;

public class Game2ToEnd2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("End 2");
        }
    }
}