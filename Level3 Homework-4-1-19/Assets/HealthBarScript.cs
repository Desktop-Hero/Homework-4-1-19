using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public Image healthBar;
    float maxHealth = 100f;
    public static float health;
    public Text healthText;

    void Start()
    {
        healthBar = GetComponent<Image> ();
        health = maxHealth;
    }

    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        healthText.text = "HP : " + health / 10;
    }
}
