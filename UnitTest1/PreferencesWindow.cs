using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace AcceptanceTests
{
    // Enums for languages selection
    internal enum Language
    {
        English,
        Czech,
        Chinese,
        Dutch,
        French,
        German,
        Hungarian,
        Italian,
        Polish,
        Romanian,
        Slovak,
        Spanish,
        Russian,
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
            preferencesWindow.Get<ComboBox>("langSelCombo").Select((int)language);
        }

        internal void ClickOnCancelButton()
        {
            preferencesWindow.Get<Button>(SearchCriteria.ByText("Cancel")).Click();
        }
    }
}