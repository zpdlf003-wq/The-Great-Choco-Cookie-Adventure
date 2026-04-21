using UnityEngine;
using UnityEngine.SceneManagement;

// Enter the name of the scene you want to move to in the editor
public class Click3 : MonoBehaviour
{
    public string nextSceneName = "Game 2";

    // Called when the object is clicked with the mouse
    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " clicked! Moving to the next scene.");
        SceneManager.LoadScene("Game 2");
    }
}
