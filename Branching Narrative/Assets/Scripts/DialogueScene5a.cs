using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

//this scene needs all of its content replaced from scene3a stuff to scene5a stuff

public class DialogueScene5a : MonoBehaviour
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

    void Start()
    {         // initial visibility settings
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

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            dialogue.SetActive(true);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Wow! It got really misty all of a sudden. Can you see anything Joan?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((Why would you think I could see anything, idiot!))";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "???";
            Char3speech.text = "*Yawn*";
        }
        else if (primeInt == 5)
        {
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "What was that!?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "???";
            Char3speech.text = "Jeez. I thought this would be a good place to nap before the ceremony... ";
        }
        else if (primeInt == 7)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Who are you?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "The names Amethyst.";
        }
        else if (primeInt == 9)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Who are you supposed to be?";
        }
        else if (primeInt == 10)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Well, I'm an up and coming wtich who needs to get to the ceremony.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 11)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((A ceremony we should be at now!!))";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar2.SetActive(true);
            ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "The cat's right. The ceremony is starting soon. Although....";
        }
        else if (primeInt == 13)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Although what?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Since you were so nice in interupting my nap. You get to help me with something.";
        }
        else if (primeInt == 15)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "What?! But I didn't even know you were here!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Oh come on! It's simple enough that a fledgeling could do it.";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Fine...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 101)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Take this stone and focus some magic into it. I need an extra power stone for a spell later.";
        }
        else if (primeInt == 102)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "*You focus your magic into the Amethyst colored stone and it starts to glow brightly*";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 103)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "There! Now I really need to go!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 104)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Huh! Not bad kid!";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "You've got some powerful magic there! I'm sure which ever path you decide, You'll excel in.";
        }
        else if (primeInt == 106)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Really? Thanks!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 107)
        {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "Ya. If you actually get there...";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 108)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Cat's right! Btter get going!";
        }
        else if (primeInt == 109)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Alright! See you around!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 111)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Ok! Almost at the school.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }

        //Encounter after choice 2
        else if (primeInt == 200)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Sorry! I'm already late and I need to leave!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 201)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Really? Come on.";
        }
        else if (primeInt == 202)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "I'm sorry but I really have to go! I'm super late!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 203)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Ugh! Fine.";
        }
        else if (primeInt == 204)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Amethyst";
            Char3speech.text = "Damn. I really need an extra power source for this spell...";
        }

        else if (primeInt == 205)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Alright. Time to get to the ceremony!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }

    }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtChar2.SetActive(false);
        Char1name.text = PlayerData.UserName;
        Char1speech.text = "Alright";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        ArtChar2.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "Amethyst";
        Char3speech.text = "What?!";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void SceneChange6()
    {
        SceneManager.LoadScene("Scene6");
    }
}