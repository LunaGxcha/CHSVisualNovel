using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameDesign : MonoBehaviour
{

    public GameObject KyleBored;
    public GameObject fadeScreen;
    public GameObject textBox;

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainText;

    void update()
    {
        textLength = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(testScene());
    }

    IEnumerator testScene() 
    {
        yield return new WaitForSeconds(2);
        fadeScreen.SetActive(false);
        KyleBored.SetActive(true);
        yield return new WaitForSeconds(2);
        //text function for episode 7
        mainText.SetActive(true);
        textToSpeak = "MC: Oh, it's pretty empty in here...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        textCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        textBox.SetActive(true);
    }
}
