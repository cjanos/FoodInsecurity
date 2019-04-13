using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] private Image shiftRemaining;
    private float timeValue;
    private float seconds;
    private int oldSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timeValue = 180;
    }

    // Update is called once per frame
    void Update()
    {
        timeValue -= Time.deltaTime;
        Vector3 myScale = shiftRemaining.transform.localScale;
        myScale.x = timeValue / 180 * 4;
        shiftRemaining.transform.localScale = myScale;
    }
}
