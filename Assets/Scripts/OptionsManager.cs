using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    public TMP_InputField nicknameUI;
    public TMP_Dropdown difficultyUI;
    public Toggle godmodeUI;

    public TextMeshProUGUI roundNumber;

    private string nickname = "patata23";
    private int difficulty = 0;
    private bool isGodModeOn = false;

    private int totalRounds = 3;
    private int maxRounds = 10;
    private int minRounds = 1;

    private string[] difficultyNames = { "Easy", "Medium", "Hard" };

    public void SetSettings()
    {
        nicknameUI.text = nickname;
        difficultyUI.value = difficulty;
        godmodeUI.isOn = isGodModeOn;
        roundNumber.text = totalRounds.ToString();
    }


    public void SetNickname(string name)
    {
        nickname = name;

        Debug.Log($"You nickname is {nickname}");
    }

    public void SetDifficulty(int index)
    {

        switch (index)
        {
            case 0:

                difficulty = index;
                break;

            case 1:

                difficulty = index;
                break;

            case 2:

                difficulty = index;
                break;
        }

        Debug.Log($"Game difficulty is {difficultyNames[difficulty]}");
    }

    public void SetGodmode(bool mode)
    {
        if (mode)
        {
            isGodModeOn = true;
        }
        else
        {
            isGodModeOn = false;
        }

        Debug.Log($"Godmode is {isGodModeOn}");
    }

    public void AddRounds()
    {
        if (totalRounds < maxRounds)
        {
            totalRounds++;

            roundNumber.text = totalRounds.ToString();

            Debug.Log($"Number rounds is {totalRounds}");
        }
    }

    public void RemoveRounds()
    {
        if (totalRounds > minRounds)
        {
            totalRounds--;

            roundNumber.text = totalRounds.ToString();

            Debug.Log($"Number rounds is {totalRounds}");
        }
    }
}
