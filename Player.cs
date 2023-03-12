using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
 public static Player Instance;

 public int Health;

 public Text HealthText;

 public void Awake()
 {
    Instance = this;
 }

 public void IncreaseHealth(int value)
 {
    Health += value;
    HealthText.text = $"HP:{Health}";
 }
}
