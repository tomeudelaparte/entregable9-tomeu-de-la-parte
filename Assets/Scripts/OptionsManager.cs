using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    // Variables públicas
    public TMP_InputField nicknameUI;
    public TMP_Dropdown difficultyUI;
    public Toggle godmodeUI;
    public TextMeshProUGUI roundNumber;
    public Slider musicVolumeUI;
    public AudioMixer audioMixer;

    // Variables privadas
    private string nickname = "patata23";
    private int difficulty = 0;
    private bool isGodModeOn = false;
    private float musicVolume = 0.75f;

    private int totalRounds = 3;
    private int maxRounds = 10;
    private int minRounds = 1;

    // Array para definir el nombre según el index de dificultad
    private string[] difficultyNames = { "Easy", "Medium", "Hard" };

    // Al iniciar ajusta las opciones con los valores "guardados"
    private void Start()
    {
        nicknameUI.text = nickname;
        difficultyUI.value = difficulty;
        godmodeUI.isOn = isGodModeOn;
        musicVolumeUI.value = musicVolume;
        roundNumber.text = totalRounds.ToString();

        SetMusicVolume(musicVolume);
    }

    // Cambia el nombre
    public void SetNickname(string name)
    {
        // Guarda el nombre
        nickname = name;

        // Muestra por consola el Nickname insertado.
        Debug.Log($"Nickname changed to {nickname}");
    }

    // Cambia la dificultad
    public void SetDifficulty(int index)
    {
        // Un switch según el valor de index
        switch (index)
        {
            // Si index es valor 0
            case 0:

                // Guarda la dificultad y para la ejecución del Switch
                difficulty = index;
                break;

            // Si index es valor 1
            case 1:

                // Guarda la dificultad y para la ejecución del Switch
                difficulty = index;
                break;

            // Si index es valor 2
            case 2:

                // Guarda la dificultad y para la ejecución del Switch
                difficulty = index;
                break;
        }

        // Muestra por consola la dificultad seleccionada.
        Debug.Log($"Game difficulty changed to {difficultyNames[difficulty]}");
    }

    // Cambia el modo invencible
    public void SetGodmode(bool mode)
    {
        // Si mode es True
        if (mode)
        {
            isGodModeOn = true;
        }

        // Si mode es False
        else
        {
            isGodModeOn = false;
        }

        // Muestra por consola el modo seleccionado.
        Debug.Log($"Godmode changed to {isGodModeOn}");
    }

    // Cambia el volúmen de la música
    public void SetMusicVolume(float volume)
    {
        // Guarda el valor volume
        musicVolume = volume;

        // Ajusta el nivel del grupo del Audio Mixer con el valor seleccionado.
        audioMixer.SetFloat("Music Volume", Mathf.Log10(volume) * 20);

        // Muestra por consola el volumen seleccionado.
        Debug.Log($"Music volume changed to {Mathf.Log10(volume) * 20}");
    }

    // Añade +1 al número de rondas
    public void AddRounds()
    {
        // Si el total de rondas es menor al máximo
        if (totalRounds < maxRounds)
        {
            // Suma +1 al total de rondas
            totalRounds++;

            // Cambia el valor mostrado por pantalla
            roundNumber.text = totalRounds.ToString();

            // Muestra por consola
            Debug.Log($"Round's number changed to {totalRounds}");
        }
    }

    // Quita -1 al número de rondas
    public void RemoveRounds()
    {
        // Si el total de rondas es mayor al mínimo
        if (totalRounds > minRounds)
        {
            // Resta -1 al total de rondas
            totalRounds--;

            // Cambia el valor mostrado por pantalla 
            roundNumber.text = totalRounds.ToString();

            // Muestra por consola
            Debug.Log($"Round's number changed to {totalRounds}");
        }
    }
}
