using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBreakoutManager : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        UpdateText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        //High Score: <score> by Name: <name>
        highScore.text = "High Score: " + DataManager.Instance.HighScore + " by Name: " + DataManager.Instance.HSPlayerName;
    }
}
