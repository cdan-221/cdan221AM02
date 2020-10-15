using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueGameHandler : MonoBehaviour
{

    public static int playerStat;
    [SerializeField] PlayerData data;
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void AddPlayerStat()
    {
        playerStat += 1;
        Debug.Log("Current Player Stat = " + playerStat);
    }

    public void RestartGame()
    {
        data.ClearChoices();
        SceneManager.LoadScene("Scene1");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

}