using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RLSKTD.Character.Player {
  /// <summary> Controls the UI of the player </summary>
  public class UIController : MonoBehaviour {
    [SerializeField] private GameObject healthSlider;

    [SerializeField] private TextMeshProUGUI healthSliderText;

    /// <summary> Initializes the UI </summary>
    private void Awake() {
      healthSlider = GameObject.Find("Health");

      healthSliderText = healthSlider.GetComponentInChildren<TextMeshProUGUI>();
    }

    /// <summary> Set the HP of the UI </summary>
    public void SetHealth(int health, int maxHealth) {
      healthSlider.GetComponent<Slider>().maxValue = maxHealth;
      healthSlider.GetComponent<Slider>().value = health;
      healthSliderText.text = health + "/" + maxHealth;
    }
  }
}


