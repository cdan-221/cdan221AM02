using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class DialogueScene4a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;
    string You = "You";
    const string Astra = "ASTRA";

    void Start()
    {         // initial visibility settings
        You = PlayerData.UserName;
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }


    private void speak(int charnumber, bool displayChoice, string charname, string speech)
    {
        dialogue.SetActive(true);
        if (charnumber == 1) // player
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            Char1name.text = charname;
            Char1speech.text = speech;
            Char2name.text = string.Empty;
            Char2speech.text = string.Empty;
            Char3name.text = string.Empty;
            Char3speech.text = string.Empty;
        }
        else if (charnumber == 2)
        {
            ArtChar2.SetActive(true);
            Char1name.text = string.Empty;
            Char1speech.text = string.Empty;
            Char2name.text = charname;
            Char2speech.text = speech;
            Char3name.text = string.Empty;
            Char3speech.text = string.Empty;
        }
        else throw new UnityException("INVALID CHARACTER NUMBER INSERT 1 OR 2!");
        nextButton.SetActive(!displayChoice);
        Choice1a.SetActive(displayChoice);
        Choice1b.SetActive(displayChoice);
    }
    private void DisplayNextScene()
    {
        NextScene1Button.SetActive(true);
        NextScene2Button.SetActive(true);
        allowSpace = false;
    }
    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            speak(1, false, string.Empty, "*Howling of the wind echos through the air*");
        }
        else if (primeInt == 3)
        {
            speak(2, false, Astra, "..... you finally made it. Do you feel it now?");
        }
        else if (primeInt == 4)
        {
            speak(1, true, You, "Who the hell are you? Its.....");
        }
        else if (primeInt == 5)
        {
        }
        else if (primeInt == 6)
        {

        }
        else if (primeInt == 7)
        {

        }
        else if (primeInt == 8)
        {

        }
        else if (primeInt == 9)
        {

        }
        else if (primeInt == 10)
        {

        }
        else if (primeInt == 11)
        {

        }
        else if (primeInt == 12)
        {

        }
        else if (primeInt == 13)
        {
        }
        else if (primeInt == 14)
        {

        }
        else if (primeInt == 15)
        {

        }
        else if (primeInt == 16)
        {
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            speak(2, false, "???", "*sigh* I guess they're still teaching everyone the same");
        }
        else if (primeInt == 101)
        {
            speak(1, false, You, "*laughs* The same? what are you talking about? ");
        }
        else if (primeInt == 102)
        {
            speak(2, false, "???", "There is a reason you cant find your way home");
        }
        else if (primeInt == 103)
        {
            speak(1, false, You, "Who even are you??");
        }
        else if (primeInt == 104)
        {
            speak(1, false, string.Empty, "*the howling of the wind grows louder");
        }
        else if (primeInt == 105)
        {
            speak(2, false, Astra, "Im Astra, you'll remember this name for a long time. still closed minded, you'll never make it in the real world");
        }
        else if (primeInt == 106)
        {
            speak(1, false, You, "SAYS WHO?! Screw you, I've worked too hard to have some random dude tell me what about MY future");
        }
        else if (primeInt == 107)
        {
            speak(1, false, You, "I'm done entertaining youre riddles. *walks away*");
        }
        else if (primeInt == 108)
        {
            speak(2, false, Astra, "I thought this would be the best way you show you.... All I can do now is pray the people on the left do a better job than I");
        }
        else if (primeInt == 109)
        {
            speak(1, false, string.Empty, "2 cloudy pathways appear from thin air in front of you");
            DisplayNextScene();
        }

        //Encounter after choice 2
        else if (primeInt == 200)
        {
            speak(2, false, Astra, "You're the first person to say that to me in 1000 years.");
        }
        else if (primeInt == 201)
        {
            speak(1, false, You, "I've never seen 1000 years looks so good.");
        }
        else if (primeInt == 202)
        {
            speak(2, false, Astra, "peace is the only way one can get access to the fountain of youth");
        }
        else if (primeInt == 203)
        {
            speak(1, false, You, "I mean yeah its peaceful I guess, but dont you get lonely??");
        }
        else if (primeInt == 204)
        {
            speak(2, false, Astra, "No Witches no School, no critique, no competition, just peace in solitude");
        }
        else if (primeInt == 205)
        {
            speak(1, false, You, "uhhhhh yeah, thats what it looks like, when was the last time you got some sleep");
        }
        else if (primeInt == 206)
        {
            speak(2, false, Astra, "I stay up wishing my loved one could join me in this bliss. maybe you'll be the witch to bring true peace to the world");
        }
        else if (primeInt == 207)
        {
            speak(1, false, You, "*sweats* yeahhhh well, my version of peace looks nothing like this.");
        }
        else if (primeInt == 208)
        {
            speak(2, false, Astra, "evolution is a must, I cannot keep you any longer maybe those on the left can show you how to bring the world to the bliss I dream of.");
        }
        else if (primeInt == 209)
        {
            speak(1, false, string.Empty, "2 cloudy pathways appear from thin air in front of you");
            DisplayNextScene();
        }

    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        primeInt = 99;
        talking();
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        primeInt = 199;
        talking();
        allowSpace = false;
    }


    public void SceneChange4a()
    {
        SceneManager.LoadScene("Scene5a");
    }
    public void SceneChange4b()
    { 
        SceneManager.LoadScene("Scene5b");
    }
}