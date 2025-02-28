using UnityEngine;
using Unity.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class HpBar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public Slider slider;
    private Camera camera;
    [SerializeField] public Transform target;
    public void UpdateHealthBar(float currenValue, float maxValue)
    {
        slider.value = currenValue / maxValue;
    }
    private void Start()
    {
        GameObject player = GameObject.Find("Casmera");
        camera = player.GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.rotation = camera.transform.rotation;
    }
}
