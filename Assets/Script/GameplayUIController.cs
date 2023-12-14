using UnityEngine;
using TMPro;

public class GameplayUIController : MonoBehaviour
{

    public TMP_Text timerText;

    public TimeManager timeManager;

    void Start()
    {
      
    }

    
    void Update()
    {
        timerText.text = timeManager.timer.ToString();
    }
}
