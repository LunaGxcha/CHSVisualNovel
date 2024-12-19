using TMpro;

public class Timer : MonoBehaviour 
{
[SerializedField] TextMeshProUGI timerText;
[SerializedField] float remainingTime;

void Update()
{
    if (remainingTime > 0)
    {
        remainingTime -= Time.deltaTime;
    }
    else if (remainingTime < 0)
    {
        remainingTime = 0;
        //GameOver();
        timerText.color = Color.red;
    }
}
int minutes = Mathf.FloorToInt(remainingTime / 60);
int seconds = Mathf.FloorToInt(remaningTime % 60);
timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
}
