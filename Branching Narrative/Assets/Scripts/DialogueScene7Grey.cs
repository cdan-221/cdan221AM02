using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7Grey : MonoBehaviour
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
            Char3speech.text = "How dare you.";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
			Char3speech.text = "One measly little ant thinks they can single handedly overthrow the order I have placed in this coven. Witches MUST choose Light or Dark. It’s always been like that and I intend to keep it like that. I keep you focused.";
            //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4)
        {
			ArtChar2.SetActive(false);
            Char1name.text = PlayerData.UserName;
            Char1speech.text = "All your doing is cutting our potential in half!";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 5)
        {
			ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Oh so your doubling down. I guess the entire history of our people was wrong because one little witch says so.";
        }
		else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = "Well you’ve chosen this path, and it will be a lonely path full of overgrowth.";
        }
		else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "High Witch";
            Char3speech.text = " I hope to never see you again";
        }
		else if (primeInt == 8)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "** A suffocating air pushes your form towards the doorway, the doors violently fling open and your body is thrown across the world, far from the High Witches sight**";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "**You live out the rest of your days in a small cottage far from the main civilization of witches. You wonder how your friends are doing but you know you're not allowed to see them ever again. Occasionally you're able to sneak out some texts on light and dark magics. You poke holes through the foundations of magic and learn how to do things in a much better way, but you have no one to share it with. **";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "**You become the most powerful witch to ever live, able to do magics that even the high witch couldn’t comprehend, if she were still alive that is. No, you didn’t kill her and overthrow the coven, you let them live out their lives the way they want to. You're just so powerful at this point that death literally cannot affect you anymore. **";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "";
        }
		else if (primeInt == 11)
        {
			ArtChar2.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "";
            Char3speech.text = "**Unfortunately, which culture has doubled down on everything being Black and White, with no room for what’s grey. So as much as you’d love to share your findings and push witch kind to new heights, you know it will not work out for you, they cannot be reasoned with. It’s better to keep to yourself. The good news is, you're able to live out your numerous days without any regrets. Knowing full well what your full potential is.**";
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