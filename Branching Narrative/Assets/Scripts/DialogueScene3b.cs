using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour
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
	public GameObject ArtCharLil;
	public GameObject ArtCharMed;
	public GameObject ArtCharBig;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
	public GameObject Choice1c;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
	public GameObject NextScene3Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtCharLil.SetActive(false);
		ArtCharMed.SetActive(false);
		ArtCharBig.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
            Char1name.text = "YOU";
            Char1speech.text = "Woah What an interesting cave… and is that.. A SUMMONING CIRCLE?";
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
            Char2speech.text = "I don’t know if I like the looks of this…";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "You worry too much, this place looks so cool!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = 
            Char3speech.text = "";
        }
		else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "???";
            Char3speech.text = "*distant sobbing*";
        }
		else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Did you hear that…";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "???";
            Char3speech.text = "Is there someone in my cave?";
        }
		else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yeah, who are you?";
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
			Char3name.text = "Baphie";
            Char3speech.text = "The name's Baphie, I was brought into this cave from my home and I don’t know where I am, I’m kinda lonely…";
        }
		else if (primeInt == 10)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "What do you mean, brought here?";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 11)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "That summoning circle that’s gone cold.. Some prankster witch summoned me and ran. I just wish I could get back home, or had a friend here with me.";
        }
		else if (primeInt == 12)
        {
			ArtChar1.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I wish I could help, but I don’t really know anything about summoning demons...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 13)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "Maybe you can! That summoning circle still has some juice in it. You can’t use it to send me back, but maybe you can use it to bring me a friend!";
        }
		else if (primeInt == 14)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Sure! But how do I even begin to…. I don’t think I can…";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 15)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "It’s easy, just place both hands on the summoning circle and envision a friend for me, it should find the closest match. ";
        }
        else if (primeInt == 16)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Okay, just let me think...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
			Choice1c.SetActive(true); // function Choice1cFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "YOU";
            Char1speech.text = "hrrggh-";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "*the circle starts glowing and....*";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 102)
        {
			ArtCharLil.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "*...*";
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
			Char3name.text = "Baphie";
            Char3speech.text = "An.. Eyeball....";
        }
		else if (primeInt == 104)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "You got me an eyeball... as a friend???";
        }
		else if (primeInt == 105)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yeah well I was thinking of very round shapes I just didn’t really focus.";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 106)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "Yeah maybe this whole summoner thing isn’t your strongest suit.... Seriously what am I supposed to do with an eye…";
        }
		else if (primeInt == 107)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Sorry...";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 108)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "Maybe this did cure my loneliness, I can’t stay in this cave with just an eye floating around.. ";
        }
		else if (primeInt == 109)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I’m truly very sorry..";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 110)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "Just go...";
        }
		else if (primeInt == 111)
        {
			ArtChar2.SetActive(false);
			ArtCharLil.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I feel kinda guilty.. But let's keep going.";
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
            Char1name.text = "YOU";
            Char1speech.text = "Grrrrr gumph";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "*The circle lights up and fills the dark cave with a red glow, something begins to form*";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 202)
        {
			ArtChar2.SetActive(true);
			ArtCharMed.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "OH MY SATAN THEY’RE SO CUTE!!!";
        }
	else if (primeInt == 203)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Haha I guess I did good~";
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
			Char3name.text = "Baphie";
            Char3speech.text = "Did good? YOU DID GREAT! I’m so happy!";
        }
	else if (primeInt == 205)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I’m glad you like your new friend.";
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
			Char3name.text = "Baphie";
            Char3speech.text = "You know you did really good, if you keep going with this type of magic you could be an amazing summoner. Are you a dark witch?";
        }
	else if (primeInt == 207)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I actually haven't decided yet...";
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
			Char3name.text = "Baphie";
            Char3speech.text = "Well give the dark side some serious thought.";
        }
	else if (primeInt == 209)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Will do!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 210)
        {
			ArtCharMed.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I’m glad we were able to help him, now where to?";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
			nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
			NextScene2Button.SetActive(true);
        }
	//Encounter after choice 3
	else if (primeInt == 300)
        {
            Char1name.text = "";
            Char1speech.text = "*The circle glows an ominous red and fills the entire cave, a flash of light knocks everybody back*";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 301)
        {
			ArtCharBig.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "*A monstrous minotaur pops out of the summoning circle* ";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 303)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Baphie";
            Char3speech.text = "Woah, what did you do?";
        }
	else if (primeInt == 304)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "I er um…";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 305)
        {
            Char1name.text = "";
            Char1speech.text = "*The minotaur looks directly at you with hatred in its eyes for taking it away from it’s home. You find yourself looking at the bottom of its massive hoof.* ";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
	else if (primeInt == 306)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Uh-oh";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
			nextButton.SetActive(false);
            allowSpace = false;
			NextScene3Button.SetActive(true);
        }
	
	
	}
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Maybe this..";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "";
        Char3speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Okay, got it!";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "";
        Char3speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
	public void Choice1cFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "AAAHHHHHHHHHHHH";
        Char2name.text = "";
        Char2speech.text = "";
		Char3name.text = "";
        Char3speech.text = "";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
	

    public void SceneChange4a()
    {
        SceneManager.LoadScene("Scene4a");
    }
    public void SceneChange4b()
    {
        SceneManager.LoadScene("Scene4b");
    }
	public void SceneChangeDEATH()
    {
        SceneManager.LoadScene("DEATH");
    }
}