namespace ParralelDz
{
    public partial class Form1 : Form
    {
        public static string text = string.Empty;

        public static int countOfSentences = 0;
        public static int countOfAskSentences = 0;
        public static int countOfExclamationSentences = 0;
        public static int countOfSymbols = 0;
        public static int countOfWords = 0;
        public CancellationTokenSource cts = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }
        private void StartButtonEvent(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();    
            text = textBox1.Text;
            string messageBoxText=string.Empty;
            List<Task> tasks = new List<Task>();
            if (checkBox1.Checked) tasks.Add(Task.Run(() => countOfSentences = text.Count(x => x.ToString() == "?" || x.ToString() == "!" || x.ToString() == "."), cts.Token));
            if (checkBox2.Checked) tasks.Add(Task.Run(() => countOfAskSentences = text.Count(x => x.ToString() == "?"), cts.Token));
            if (checkBox3.Checked) tasks.Add(Task.Run(() => countOfExclamationSentences = text.Count(x => x.ToString() == "!"), cts.Token));
            if (checkBox4.Checked) tasks.Add(Task.Run(() => countOfWords = text.Split(" ").Length - 1, cts.Token));
            if (checkBox5.Checked) tasks.Add(Task.Run(() => {
                foreach (var symbol in text)
                {
                    if (symbol != ' ')
                    {
                        countOfSymbols++;
                    }

                }
            }, cts.Token));
            Task.WaitAll(tasks.ToArray());
            if (checkBox1.Checked) messageBoxText += $"Количество предложений: {countOfSentences}\n";
            if (checkBox2.Checked) messageBoxText += $"Количество вопросительных предложений: {countOfExclamationSentences}\n";
            if (checkBox3.Checked) messageBoxText += $"Количество восклицательных предложений: {countOfExclamationSentences}\n";
            if (checkBox4.Checked) messageBoxText += $"Количество слов: {countOfWords}\n";
            if (checkBox5.Checked) messageBoxText += $"Количество символов: {countOfSymbols}\n";
            //Повтор кода это нехорошо, но такое решение мне больше всего нравится
            MessageBox.Show(messageBoxText,string.Empty,MessageBoxButtons.OK);
            countOfSymbols = 0;
            countOfWords = 0;
            countOfSentences = 0;
            countOfExclamationSentences = 0;
            countOfSentences = 0;
            
        }
        public void StopButtonEvent(object sender, EventArgs e)
        {
            countOfSymbols = 0;
            countOfWords = 0;
            countOfSentences = 0;
            countOfExclamationSentences = 0;
            countOfSentences = 0;
            cts.Cancel();
        }

  
    }
}
