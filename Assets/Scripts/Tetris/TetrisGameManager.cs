using TMPro;

private int score;
public TextMeshProUGUI scoreText;

  void Start() {
    StartCoroutine(SpawnTarget());
    score = 0;
    scoreText.text = "Score: " + score; }
