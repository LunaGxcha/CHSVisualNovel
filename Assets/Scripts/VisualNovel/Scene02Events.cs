using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene02Events : MonoBehaviour
{ 
    public GameObject fadeinscreen;
    public GameObject MC;
    public GameObject classA;
    public GameObject TextBoxOne;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox4;
    public GameObject TextBox5;

    [SerializeField] string textToSpeak

    void Start()
    {
        StartCoroutine(EventStart());


    }

   IEnumerator EventStart()
   {
    yield return new WaitForSeconds(10);
    fadeinscreen.SetActive(false);
    
    yield return new WaitForSeconds(2);
    TextBoxOne.SetActive(true);
    yield return new WaitFor(Input.GetMouseButtonDown(0));
    TextBoxOne.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox2.SetActive(true);
    yield return new WaitFor(Input.GetMouseButtonDown(0));
    TextBox2.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox3.SetActive(true);
    yield return new WaitFor(Input.GetMouseButtonDown(0));
    TextBox3.SetActive(false);
     yield return new WaitForSeconds(2);
     // if poster is chosen
    TextBox4.SetActive(true);
    yield return new WaitFor(Input.GetMouseButtonDown(0));
    TextBox4.SetActive(false);
     yield return new WaitForSeconds(2);
     //if door is chosen
    TextBox5.SetActive(true);
    yield return new WaitFor(Input.GetMouseButtonDown(0));
    TextBox5.SetActive(false);



   }

}
