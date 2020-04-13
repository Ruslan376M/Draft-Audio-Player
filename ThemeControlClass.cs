namespace Music_Speed_And_Pitch_Changer
{
    class ThemeControlClass
    {
        public System.Drawing.Color firstColor = System.Drawing.Color.White;//Главный цвет приложения
        public System.Drawing.Color secondColor = System.Drawing.Color.Black;//Цвет текста
        public System.Drawing.Color thirdColor = System.Drawing.Color.Gainsboro;//Дополнительный цвет
        public System.Drawing.Color accentColor = System.Drawing.Color.SteelBlue;//Акцентный цвет

        public void SetWhiteTheme()
        {
            firstColor = System.Drawing.Color.White;
            secondColor = System.Drawing.Color.Black;
            thirdColor = System.Drawing.Color.DarkGray;
            applyAll();
        }

        public void SetBlackTheme()
        {
            firstColor = System.Drawing.Color.Black;
            secondColor = System.Drawing.Color.White;
            thirdColor = System.Drawing.Color.DarkGray;
            applyAll();
        }

        public void applyAll()
        {
            if (Program.aboutWindow != null)
                Program.aboutWindow.applyTheme();
            if (Program.editorWindow != null)
                Program.editorWindow.applyTheme();
            if (Program.effectsWindow != null)
                Program.effectsWindow.applyTheme();
            if (Program.mainWindow != null)
                Program.mainWindow.applyTheme();
            if (Program.musicListWindow != null)
                Program.musicListWindow.applyTheme();
            if (Program.settingsWindow != null)
                Program.settingsWindow.applyTheme();
        }
    }
}
