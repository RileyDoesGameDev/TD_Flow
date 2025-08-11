using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelManager : MonoBehaviour
{
    public string[] sceneName;

    public static bool isGamePaused = false;

    [SerializeField] GameObject pauseCanvas;
    [SerializeField] GameObject gameUI;

    public void OnStartLoad()
    {
        SceneManager.LoadScene(sceneName[0], LoadSceneMode.Single);
    }

    public void OnSettingsLoad()
    {
        SceneManager.LoadScene(sceneName[1], LoadSceneMode.Single);
        //GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();
    }

    public void OnGameWonLoad()
    {
        SceneManager.LoadScene(sceneName[2], LoadSceneMode.Single);
    }

    public void OnTitleLoad()
    {
        SceneManager.LoadScene(sceneName[3], LoadSceneMode.Single);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isGamePaused)
            {
                OnPause();
            }

            else
            {
                OnResume();
            }
        }
    }

    public void OnPause()
    {
        isGamePaused = true;
        
        Time.timeScale = 0.0f;
        
        pauseCanvas.SetActive(true);
        gameUI.SetActive(false);

        UnityEngine.Cursor.lockState = CursorLockMode.None;
    }

    public void OnResume()
    {
        isGamePaused = false;

        Time.timeScale = 1.0f;

        pauseCanvas.SetActive(false);
        gameUI.SetActive(true);

        UnityEngine.Cursor.lockState = CursorLockMode.Confined;
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
