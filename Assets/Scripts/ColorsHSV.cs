using UnityEngine;
using UnityEngine.UI;

public class ColorsHSV : MonoBehaviour
{
    float m_Hue;
    float m_Saturation;
    float m_Value;

    [Range(0.0f, 1.0f)]
    public float m_SliderHue, m_SliderSaturation, m_SliderValue;

    Renderer m_Renderer;
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        // m_SliderHue = 1;
        // m_SliderSaturation = 1;
        // m_SliderValue = 1;
    }
    void Update()
    {
        m_Hue = m_SliderHue;
        m_Saturation = m_SliderSaturation;
        m_Value = m_SliderValue;
        m_Renderer.material.color = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);

        Debug.Log("HSV: " + m_Hue + ", " + m_Saturation + ", " + m_Value + 
          " | RGB: " + Color.HSVToRGB(m_Hue, m_Saturation, m_Value));

        Debug.Log("Slider Values -> Hue: " + m_SliderHue + ", Sat: " + m_SliderSaturation + ", Val: " + m_SliderValue);
    }
}
