using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace UnitTest1
{
    // Enums for languages
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

        internal void SwitchLanguage(Language language)
        {
            preferencesWindow.Get<ComboBox>("langSelCombo").Select(language);
            preferencesWindow.Get<Button>(SearchCriteria.ByText("Cancel")).Click();
        }
    }
}