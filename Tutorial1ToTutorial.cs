using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial1ToTutorial : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}