using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public TextMeshProUGUI counterGUI;
    private int counter = 0;
    public Light lighting;

    public TextMeshProUGUI buttonGUI;
    public AudioSource buttonSFX;

    public string nextLevelName; 

    // Start is called before the first frame update
    void Start()
    {
        //Update the counterGUI text to display current count
        counterGUI.SetText("Counter: " + counter);
        buttonGUI.SetText("Turn Off");
        //Update the buttonGUI to say "Turn Off"
    }


    public void TurnLightOnOff()
    {
        if (lighting.enabled)
        {
            lighting.enabled = false;
            buttonGUI.SetText("Turn On");
            //Update the buttonGUI to say "Turn On" 
        }
        else
        {
            lighting.enabled = true;
            counter++;
            lighting.color = new Color(Random.Range(0,0.99f), Random.Range(0, 0.99f), Random.Range(0, 0.99f), 1);
            counterGUI.SetText("Counter: " + counter);
            buttonGUI.SetText("Turn Off");

            //Update the counterGUI text to display current count
            //Update the buttonGUI to say "Turn Off"
        }
        buttonSFX.Play();
    }

    public void goToNextLevel()
    {
        SceneManager.LoadScene("MenuScene");
        buttonSFX.Play();

        //Use the buttonSFX to play when this function executes
    }
}
