namespace mod3chap2task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string wordToSearch = searchWordTextBox.Text;
            string directoryPath = directoryPathTextBox.Text;

            if (string.IsNullOrWhiteSpace(wordToSearch) || string.IsNullOrWhiteSpace(directoryPath))
            {
                MessageBox.Show("Будь ласка, введіть слово та шлях до директорії.");
                return;
            }

            resultListBox.Items.Clear();
            await SearchWordInDirectoryAsync(directoryPath, wordToSearch);
        }

        private async Task SearchWordInDirectoryAsync(string directoryPath, string wordToSearch)
        {
            string[] files = new string[1];
            files = Directory.GetFiles(directoryPath, "*.txt", SearchOption.AllDirectories);

            foreach (string filePath in files)
            {
                await Task.Run(() =>
                {
                    int wordCount = File.ReadLines(filePath)
                        .SelectMany(line => line.Split(' '))
                        .Count(word => word.Equals(wordToSearch, StringComparison.OrdinalIgnoreCase));

                    if (wordCount > 0)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            resultListBox.Items.Add($"Назва файлу: {Path.GetFileName(filePath)}");
                            resultListBox.Items.Add($"Шлях до файлу: {filePath}");
                            resultListBox.Items.Add($"Кількість входження слова: {wordCount}");
                            resultListBox.Items.Add("");
                        }));
                    }
                });
            }
        }
    }
}