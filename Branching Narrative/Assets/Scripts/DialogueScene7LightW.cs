using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7LightW : MonoBehaviour
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
	public GameObject ArtCharLIGHT;
    public GameObject ArtBG1;
	public GameObject ArtBG2;
    public GameObject NextSceneENDButton;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtCharLIGHT.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        NextSceneENDButton.SetActive(false);
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
			ArtChar2.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "You choose light magic, very well!";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "High Witch";
            Char2speech.text = "You’ve shown marvelous potential in the Light Arts, and I’m sure you’ll be happy to see some familiar faces…";
			Char3name.text = "";
			Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar2.SetActive(false);
			ArtCharLIGHT.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Light Ones";
            Char2speech.text = "Remember Us! From the woods.";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 5)
        {
			ArtCharLIGHT.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "Oh hey guys!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 6)
        {
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "You were leading me down the path of light this whole time!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 7)
        {
			ArtCharLIGHT.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Light Ones";
            Char2speech.text = "Yes, and we’re glad you decided to join our ranks!";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 8)
        {
			ArtCharLIGHT.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "I cannot wait to get started!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "**You became a very promising light witch of the community, mastering all the books of light magic with ease. You even taught light magic at the school for a while before moving on to writing your own spellbooks. The thousands of years of light magic spells have been getting old for you and you wish to explore something new.**";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "**Sadly your powers only allow you to perform light spells, and though you found much success in doing so, you also found the world started shrinking. You wonder what you could’ve been if allowed to reach your full potential.**";
			nextButton.SetActive(false);
            allowSpace = false;
            NextSceneENDButton.SetActive(true);
        }
	}
	

    public void SceneChangeEND()
    {
        SceneManager.LoadScene("MainMenu");
    }
}