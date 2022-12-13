using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _options;
    [SerializeField] private Button _buttonUp;
    [SerializeField] private Button _buttonDown;
    [SerializeField] private Toggle _toggleUp;
    [SerializeField] private Toggle _toggleDown;
    [SerializeField] private TMP_Dropdown _dropdownUp;
    [SerializeField] private TMP_Dropdown _dropdownDown;
    [SerializeField] private Slider _sliderUp;
    [SerializeField] private Slider _sliderDown;

    void Start()
    {
        _options.onClick.AddListener(OnButtonOptionClickHandler);
        _buttonUp.onClick.AddListener(OnButtonUpClickHandler);
        _buttonDown.onClick.AddListener(OnButtonDownClickHandler);
        _toggleUp.onValueChanged.AddListener(OnToggleUpClickHandler);
        _toggleDown.onValueChanged.AddListener(OnToggleDownClickHandler);
        _dropdownUp.onValueChanged.AddListener(OnDropdownUpChangeHandler);
        _dropdownDown.onValueChanged.AddListener(OnDropdownDownChangeHandler);
        _sliderUp.onValueChanged.AddListener(OnSliderUPChangeHandler);
        _sliderDown.onValueChanged.AddListener(OnDSliderDownChangeHandler);

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnButtonOptionClickHandler()
    {
        Debug.Log($"[{GetType().Name}][onButtonOptionClickHandler] clicked");
    }
    private void OnButtonUpClickHandler()
    {
        Debug.Log($"[{GetType().Name}][onButtonUpClickHandler] clicked");
    }
    private void OnButtonDownClickHandler()
    {
        Debug.Log($"[{GetType().Name}][onButtonDownClickHandler] clicked");
    }
    private void OnToggleUpClickHandler(bool isOn)
    {
        Debug.Log($"[{GetType().Name}][onToggleUPClickHandler] clicked value is on : {isOn}");
    }
    private void OnToggleDownClickHandler(bool isOn)
    {
        Debug.Log($"[{GetType().Name}][onToggleDownClickHandler] clicked value is on : {isOn}");
    }
   
    private void OnDropdownUpChangeHandler(int value)
    {
        Debug.Log($"[{GetType().Name}][OnDropdownUpChangeHandler] option {_dropdownUp.value} is selected");
    }

    private void OnDropdownDownChangeHandler(int value)
    {
        Debug.Log($"[{GetType().Name}][OnDropdownDownVhangeHandler] {value} is selected");
    }

    private void OnSliderUPChangeHandler(float value)
    {
        Debug.Log($"[{GetType().Name}][OnSliderUPChangeHandler] {value} is selected");
    }

    private void OnDSliderDownChangeHandler(float value)
    {
        Debug.Log($"[{GetType().Name}][OnDSliderDownChangeHandler] {value} is selected");
    }


}
