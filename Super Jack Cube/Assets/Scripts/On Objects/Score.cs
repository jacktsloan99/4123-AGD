using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //Code adapted from Alexander Zotov
    //Youtube link: https://www.youtube.com/watch?v=QbqnDbexrCw
    //Variables
    public static int scoreValue = 0;
    TextMeshProUGUI scoreShown;

    // Start is called before the first frame update
    void Start()
    {
        scoreShown = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreShown.text = "Score: " + scoreValue;
    }
}
