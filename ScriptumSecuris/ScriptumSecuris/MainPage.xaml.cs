namespace ScriptumSecuris
{
    public partial class MainPage: ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is Picker picker)
            {
                if(picker.SelectedIndex == 0)
                    return;

                var selectedOption = picker.SelectedItem;
                if(selectedOption != null)
                {
                    label.Text = selectedOption.ToString();

                    switch(selectedOption)
                    {
                        case "Open":
                        // Логика для открытия файла
                        break;
                        case "Save":
                        // Логика для сохранения файла
                        break;
                        case "Save As":
                        // Логика для сохранения файла как
                        break;
                    }


                }
                // Сбрасываем выбранный элемент
                picker.SelectedIndex = 0;
            }
        }

        private void FilePicker_Loaded(object sender, EventArgs e)
        {
            if(sender is Picker picker)
            {
                picker.SelectedIndex = 0;
            }
        }
    }

}
