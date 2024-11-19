namespace ParralelDz
{
    public partial class Form1 : Form
    {
        public string sourceDir = string.Empty;
        public string targetDir = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsDirsExists()
        {
            if (Directory.Exists(sourceDir) && Directory.Exists(targetDir))
            {
                return true;
            }
            else return false;
        }
        public bool IsDuplicateFile(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            string[] filesInDestination = Directory.GetFiles(targetDir);
            foreach (string file in filesInDestination)
            {
                if (Path.GetFileName(file) == fileName)
                {
                    return true;
                }
            }
            return false;
        }
        public void StartProgram(object sender, EventArgs e)
        {
            sourceDir = textBox1.Text;
            targetDir = textBox2.Text;
            if (IsDirsExists() == true)
            {
                try
                {
                    List<string> sourceFiles = Directory.GetFiles(sourceDir).ToList();
                    int filesCount = 0;
                    foreach (string file in sourceFiles)
                    {
                        if (IsDuplicateFile(file))
                        {
                            string targetPath = Path.Combine(targetDir, Path.GetFileName(file));
                            File.Copy(file, targetPath, true);
                            filesCount++;
                        }
                    }
                    MessageBox.Show($"Директория донор: {sourceDir}\n" +
                        $"Директория приемник: {targetDir}\n" +
                        $"Перенесено файлов: {filesCount}");//отчет сделал в MessageBox, так как в задании не сказано в каком формате его делать
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }       
            else
            {
                MessageBox.Show($"Директории указаны некорректно");
            }
        }
  
    }
}
