using System.Collections;
using System. Collections.Generic;
using UnityEngine;
using TMPro;

public class textCreator : MonoBehaviour
{
    public static TMPro.TMP_Text;
    public static bool runTextPrint;
    public static int charCount;
    public static string viewText;
    [SerializeField] string transferText;
    [SerializeField] int internalCount;

    void update() 
    {
        internalCount = charCount;
        charCount = GetComponent<TMPro.TMP_Text>().text.Length;
        if(runTextPrint == true)
        {
            runTextPrint = false;
            viewtext = GetComponent<TMPro.TMP_Text>();
            transferText = viewText.text;
            viewText.text = "";
            StartCoroutine(RollText());
        }
    }

    IEnumerator RollText()
    {
        foreach (char c in transferText) 
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.03);
        }
    }
}
