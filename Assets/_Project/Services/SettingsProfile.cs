using System;
using ENA.Maps;
using UnityEngine;

namespace ENA.Services
{
    [Serializable]
    [CreateAssetMenu(fileName="New Profile", menuName="ENA/Settings Profile")]
    public class SettingsProfile: ScriptableObject
    {
        #region Variables
        public ENAProfile LoggedProfile {get; set;}
        [Header("Gameplay Settings")]
        public bool AddStartingPoint;
        public bool ElementsDisappearEnabled;
        public bool GyroEnabled;
        public bool MinimapEnabled;
        public bool ObjectiveZoneEnabled;
        public bool VREnabled;
        public bool VibrationEnabled;
        public float AccessibilitySpeechRate;
        #endregion
        #region Methods
        private void GetBool(string key, out bool value)
        {
            int rawValue = PlayerPrefs.GetInt(key);
            value = Convert.ToBoolean(rawValue);
        }

        private void GetFloat(string key, out float value)
        {
            int rawValue = PlayerPrefs.GetInt(key);
            value = rawValue;
        }

        public void Load()
        {
            GetBool(nameof(AddStartingPoint), out AddStartingPoint);
            GetBool(nameof(ElementsDisappearEnabled), out ElementsDisappearEnabled);
            GetBool(nameof(GyroEnabled), out GyroEnabled);
            GetBool(nameof(MinimapEnabled), out MinimapEnabled);
            GetBool(nameof(ObjectiveZoneEnabled), out ObjectiveZoneEnabled);
            GetBool(nameof(VREnabled), out VREnabled);
            GetBool(nameof(VibrationEnabled), out VibrationEnabled);
            GetFloat(nameof(AccessibilitySpeechRate), out AccessibilitySpeechRate);
        }

        public void Reset()
        {
            ResetKey(nameof(AddStartingPoint), out AddStartingPoint);
            ResetKey(nameof(ElementsDisappearEnabled), out ElementsDisappearEnabled);
            ResetKey(nameof(GyroEnabled), out GyroEnabled);
            ResetKey(nameof(MinimapEnabled), out MinimapEnabled);
            ResetKey(nameof(ObjectiveZoneEnabled), out ObjectiveZoneEnabled);
            ResetKey(nameof(VREnabled), out VREnabled);
            ResetKey(nameof(VibrationEnabled), out VibrationEnabled);
            ResetKey(nameof(AccessibilitySpeechRate), out AccessibilitySpeechRate);
        }

        private void ResetKey(string key, out bool value)
        {
            PlayerPrefs.DeleteKey(key);
            value = false;
        }

        private void ResetKey(string key, out float value)
        {
            PlayerPrefs.DeleteKey(key);
            value = 0;
        }

        public void Save()
        {
            SetBool(nameof(AddStartingPoint), in AddStartingPoint);
            SetBool(nameof(ElementsDisappearEnabled), in ElementsDisappearEnabled);
            SetBool(nameof(GyroEnabled), in GyroEnabled);
            SetBool(nameof(MinimapEnabled), in MinimapEnabled);
            SetBool(nameof(ObjectiveZoneEnabled), in ObjectiveZoneEnabled);
            SetBool(nameof(VREnabled), in VREnabled);
            SetBool(nameof(VibrationEnabled), in VibrationEnabled);
            SetFloat(nameof(AccessibilitySpeechRate), in AccessibilitySpeechRate);
        }

        public void SetAcessibility(bool value)
        {
            // UAP_AccessibilityManager.EnableAccessibility(value);
        }

        private void SetBool(string key, in bool value)
        {
            int rawValue = Convert.ToInt32(value);
            PlayerPrefs.SetInt(key, rawValue);
        }

        private void SetFloat(string key, in float value)
        {
            int rawValue = Convert.ToInt32(value);
            PlayerPrefs.SetInt(key, rawValue);
        }

        public void SetElementsDisappear(bool value)
        {
            ElementsDisappearEnabled = value;
        }

        public void SetGyro(bool value)
        {
            GyroEnabled = value;
        }

        public void SetMinimap(bool value)
        {
            MinimapEnabled = value;
        }

        public void SetVibration(bool value)
        {
            VibrationEnabled = value;
        }

        public void SetVR(bool value)
        {
            VREnabled = value;
        }

        public void SetAddStartingPoint(bool value)
        {
            AddStartingPoint = value;
        }

        public void SetObjectiveZone(bool value)
        {
            ObjectiveZoneEnabled = value;
        }

        public void SetAccessibilitySpeechRate(float value)
        {
            AccessibilitySpeechRate = value;
        }
        #endregion
    }
}