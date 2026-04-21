using UnityEngine;
using UnityEngine.SceneManagement;

// Enter the name of the scene you want to move to in the editor
public class Click1 : MonoBehaviour
{
    public string nextSceneName = "Game";

    // Called when the object is clicked with the mouse
    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " clicked! Moving to the next scene.");
        SceneManager.LoadScene("Game");
    }
}
