{ 
    public GameObject TextBox1;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox4;
    public GameObject TextBox5;
    public GameObject TextBox6;
    public GameObject TextBox7;
    public GameObject TextBox8;
    public GameObject TextBox9;
    public GameObject TextBox10;
    public GameObject TextBox11;
    public GameObject TextBox12;
    public GameObject TextBox13;
    public GameObject TextBox14;
    public GameObject TextBox15;
    public GameObject TextBox16;
    public GameObject TextBox17;
    public GameObject TextBox18;
    public GameObject TextBox19;
    

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
    TextBox1.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox1.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox2.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox2.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox3.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox3.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox4.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox4.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox5.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox5.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox6.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox6.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox7.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox7.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox8.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox8.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox9.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox9.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox10.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox10.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox11.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox11.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox12.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox12.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox13.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox13.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox14.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox14.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox15.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox15.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox16.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox16.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox17.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox17.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox18.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox18.SetActive(false);
     yield return new WaitForSeconds(2);
    TextBox19.SetActive(true);
    yield return new WaitForSeconds(4);
    TextBox19.SetActive(false);
     




   }

}
