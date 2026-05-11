using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;

    [Header("UI Reference")]
    public TMP_Text dateText;

    public Image pauseBtnImage;
    public Image speed1xBtnImage;
    public Image speed3xBtnImage;

    [Header("Color Effect Settings")]
    public Color activeColor = Color.white;

    public Color inactiveColor = new Color(0.3f, 0.3f, 0.3f, 1f);

    private DateTime currentDate;
    private float timer = 0f;
    private float timeSpeed = 1f;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentDate = new DateTime(2098, 1, 1);
        UpdateDateUI();

        Speed1x();
    }

    void Update()
    {
        timer += Time.deltaTime * timeSpeed;

        if (timer >= 1f)
        {
            currentDate = currentDate.AddDays(1);
            timer = 0f;
            UpdateDateUI();
        }
    }

    public void UpdateDateUI()
    {
        dateText.text = currentDate.ToString("yyyy - MM - dd");
    }

    public void Pause()
    {
        timeSpeed = 0f;
        ApplyColorEffect(pauseBtnImage);
    }

    public void Speed1x()
    {
        timeSpeed = 1f;
        ApplyColorEffect(speed1xBtnImage);
    }

    public void Speed3x()
    {
        timeSpeed = 3f;
        ApplyColorEffect(speed3xBtnImage);
    }

    private void ApplyColorEffect(Image activeImage)
    {
        if (pauseBtnImage != null) pauseBtnImage.color = inactiveColor;
        if (speed1xBtnImage != null) speed1xBtnImage.color = inactiveColor;
        if (speed3xBtnImage != null) speed3xBtnImage.color = inactiveColor;

        if (activeImage != null) activeImage.color = activeColor;
    }

    public string GetCurrentDate()
    {
        return currentDate.ToString("yyyy - MM - dd");
    }
}