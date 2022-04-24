using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RLSKTD.Character.Player
{
    /// <summary> Controls the UI of the player </summary>
    public class UIController : MonoBehaviour
    {
        [SerializeField]private GameObject hpSlider;
        [SerializeField]private GameObject mpSlider;

        [SerializeField]private TextMeshProUGUI hpSliderText;
        [SerializeField]private TextMeshProUGUI mpSliderText;

        /// <summary> Initializes the UI </summary>
        private void Awake() {

            hpSlider = GameObject.Find("HP"); // Find the HP slider
            mpSlider = GameObject.Find("MP"); // Find the MP slider

            hpSliderText = hpSlider.GetComponentInChildren<TextMeshProUGUI>(); // Find the HP slider text
            mpSliderText = mpSlider.GetComponentInChildren<TextMeshProUGUI>(); // Find the MP slider text

            SetHP(this.gameObject.GetComponent<Foundation>().Hp, this.gameObject.GetComponent<Foundation>().MaxHp);
            SetMP(this.gameObject.GetComponent<Foundation>().Mp, this.gameObject.GetComponent<Foundation>().MaxMp);  
        }
        
        /// <summary> Set the HP of the UI </summary>
        public void SetHP(int hp, int maxHp)
        {
            hpSlider.GetComponent<Slider>().maxValue = maxHp;
            hpSlider.GetComponent<Slider>().value = hp;
            hpSliderText.text = hp + "/" + maxHp;
        }

        /// <summary> Set the MP of the UI </summary>
        public void SetMP(int mp, int maxMp)
        {
            mpSlider.GetComponent<Slider>().maxValue = maxMp;
            mpSlider.GetComponent<Slider>().value = mp;
            mpSliderText.text = mp + "/" + maxMp;
        }
    }
}


