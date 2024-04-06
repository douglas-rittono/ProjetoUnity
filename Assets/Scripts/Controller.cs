using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public TextMeshProUGUI txtPrincipal;
    public TextMeshProUGUI txtScore;

    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txtPrincipal.text = "Hello World!";
        txtScore.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        txtScore.text = "Score: " + score;
    }
}
