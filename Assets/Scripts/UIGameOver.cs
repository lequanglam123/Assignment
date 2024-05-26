using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    ASM_MN ASM_MN;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        ASM_MN = FindObjectOfType<ASM_MN>();
    }

    void Start()
    {
        scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();

        ASM_MN.YC1();
        ASM_MN.YC2();
        ASM_MN.YC3();
        ASM_MN.YC4();
        ASM_MN.YC5();
        ASM_MN.YC6();
        ASM_MN.YC7();
    }

    


}
