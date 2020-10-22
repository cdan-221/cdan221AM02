using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

//this scene needs all of its content replaced from scene3a stuff to scene5b stuff

public class DialogueScene5b : MonoBehaviour
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
            Char1speech.text = "Man! It got really dark all of a sudden...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            dialogue.SetActive(true);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Hey Joan! Can you see anything?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 4)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((The only thing I see is your sheer ability to get completely lost!! Come on!!))";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 5)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "???";
            Char3speech.text = "Well well. What precious little mouse has come into my den.";
        }
		else if (primeInt == 6)
        {
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "That's not chilling at all.....";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 7)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "You may call me Adelia mouse.";
        }
		else if (primeInt == 8)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Umm... Ok can you tell me how to get to the school Adelia?";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 9)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "OOh! An up and coming witch!";
        }
        else if (primeInt == 10)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Adelia";
            Char3speech.text = "Well little witch care to help me with a little spell?";
        }
        else if (primeInt == 11)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Well.... I really need to leave...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 12)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "It needn't take but a moment of your time.";
        }
        else if (primeInt == 13)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "What do you think Joan?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
			ArtChar1.SetActive(true);
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((Wow! Asking for my advice huh?))";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((You must really be in touble!))";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 16)
        {
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "Now now. No need to be so brash kitty. Heehee!";
        }
		else if (primeInt == 17)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Hmm what should I do...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
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
            Char1speech.text = "Ok. What do I need to do.";
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
			Char3name.text = "Adelia";
            Char3speech.text = "All I need is you to lend me your power for this tiny spell.";
        }
        else if (primeInt == 102)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Umm.. Ok...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 103)
        {
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "Adelia";
            Char3speech.text = "Now give me your hand.";
        }
        else if (primeInt == 104)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "*You give Adelia your hand cautiously. But the moment she grabs it, you feel a massive amount of magic leave your body.*";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 105)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "*Pant* What the heck! You didn't say that you would take most of my stored up magic!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 106)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "I need that for the ceremony!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 107)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "Well if you can't handle a little spell like that, you'll never make it as a true witch!";
        }
		else if (primeInt == 108)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "Now! Off to the school with you!";
        }
		else if (primeInt == 109)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "*Pant* Now I'm super tired....";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 110)
        {
			ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joan";
            Char2speech.text = "((You're own fault for being such a bleeding heart!))";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 111)
        {
            ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "*Sigh* Well whatever. Let's get going.";
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
            Char1speech.text = "I'm sorry but I really have to go!";
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
			Char3name.text = "Adelia";
            Char3speech.text = "You wouldn't do well to cross me deary.";
        }
	else if (primeInt == 202)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Fine just a little power, but only the amount from this crystal!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "*you take one of the crystals in your pocket and fill it with power. You then give it to Adelia*";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 204)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "Hmm.. Very well. I'll take it.";
        }
	else if (primeInt == 205)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Good! Now which way to the ceremony?";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 206)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Adelia";
            Char3speech.text = "Straight on through the woods should get you there.";
        }
	else if (primeInt == 207)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Thank you.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 208)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Minori";
            Char3speech.text = "Whatever.";
        }
	else if (primeInt == 209)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Alright. Almost there.";
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
		ArtChar2.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "Adelia";
        Char3speech.text = "Wonderful!";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        ArtChar2.SetActive(false);
        ArtChar1.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Joan";
        Char2speech.text = "((You don't have time for this!))";
		Char3name.text = "";
        Char3speech.text = "";
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