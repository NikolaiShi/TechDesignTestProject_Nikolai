using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class language_switcher : MonoBehaviour
{  
    public void SetLanguage(string languageCode)
    {
        Locale selectedLocale = LocalizationSettings.AvailableLocales.GetLocale(new System.Globalization.CultureInfo(languageCode));
        LocalizationSettings.SelectedLocale = selectedLocale;
        
    }
}