using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI killCounter;
    public Slider health;
    // Start is called before the first frame update
    void Start()
    {
        health.maxValue = player.maxHealth;
        health.value = player.currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health.value = player.currentHealth;
        killCounter.text = player.killCount.ToString();
    }
}
