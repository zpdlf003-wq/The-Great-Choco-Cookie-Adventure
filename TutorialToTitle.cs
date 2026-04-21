using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialToTitle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }
    }
}