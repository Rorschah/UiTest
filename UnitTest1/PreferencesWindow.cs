using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace UnitTest1
{
    // Enums for languages selection
    internal enum Language
    {
        Italian,
        English
    }

    internal class PreferencesWindow
    {
        private readonly Window preferencesWindow;

        public PreferencesWindow(Window preferencesWindow)
        {
            this.preferencesWindow = preferencesWindow;
        }

        internal void SwitchLanguage(string language)
        {
            preferencesWindow.Get<ComboBox>("langSelCombo").Select(language);
        }

        internal void ClickOnCancelButton()
        {
            preferencesWindow.Get<Button>(SearchCriteria.ByText("Cancel")).Click();
        }
    }
}