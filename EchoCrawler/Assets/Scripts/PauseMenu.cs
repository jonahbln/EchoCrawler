using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Text levelTitle;
    LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
        levelTitle.gameObject.SetActive(false);
    }

    public void Resume()
    {
        levelManager.Resume();
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        levelTitle.gameObject.SetActive(true);
    }

    public void MainMenu()
    {
        levelManager.ReturnToMainMenu();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
