using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void play() {
        SceneManager.LoadScene("Play");
    }

    public void quit() {
        Application.Quit();
    }

}