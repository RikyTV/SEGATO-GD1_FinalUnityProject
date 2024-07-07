using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloadQuit : MonoBehaviour
{
    public KeyCode _InputReload;
    public KeyCode _IntputQuit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_InputReload))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        if (Input.GetKeyDown(_IntputQuit))
            Application.Quit();
    }
}