using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadInput(string input)
    {
        playerName = input;
        DataManager.Instance.PlayerName = playerName;
        Debug.Log(input);
        Debug.Log("playerName is: " + playerName);
        Debug.Log("DataManager Instance Playername: " + DataManager.Instance.PlayerName);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
    
}
