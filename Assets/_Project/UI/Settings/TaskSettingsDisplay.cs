using ENA.Services;
using UnityEngine;
using UnityEngine.UI;

namespace ENA.UI
{
    public class TaskSettingsDisplay: UIPanel
    {
        #region Variables
        [SerializeField] SettingsProfile profile;
        [Header("References")]
        [SerializeField] Toggle addStartingPointToggle;
        [SerializeField] Toggle elementsDisappearToggle;
        [SerializeField] Toggle gyroToggle;
        [SerializeField] Toggle minimapToggle;
        [SerializeField] Toggle objectiveZoneEnabledToggle;
        [SerializeField] Toggle vrToggle;
        [SerializeField] Toggle vibrationToggle;
        [SerializeField] Slider accessibilitySpeechRateSlider;
        #endregion
        #region Methods
        private void OnEnable()
        {
            addStartingPointToggle.isOn = profile.AddStartingPoint;
            elementsDisappearToggle.isOn = profile.ElementsDisappearEnabled;
            gyroToggle.isOn = profile.GyroEnabled;
            minimapToggle.isOn = profile.MinimapEnabled;
            objectiveZoneEnabledToggle.isOn = profile.ObjectiveZoneEnabled;
            vrToggle.isOn = profile.VREnabled;
            vibrationToggle.isOn = profile.VibrationEnabled;
            accessibilitySpeechRateSlider.value = profile.AccessibilitySpeechRate;
        }
        #endregion
    }
}