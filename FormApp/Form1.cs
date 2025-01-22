namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSenkron_Click(object sender, EventArgs e)
        {
            // Ýlk çaðrý
            ChangeTexts(Color.LightGreen, "birinci");

            // Ýkinci çaðrý
            ChangeTexts(Color.Green, "ikinci");

            // Üçüncü çaðrý
            ChangeTexts(Color.DarkGreen, "üçüncü");
        }

        private async void btnAsenkron_Click(object sender, EventArgs e)
        {
            // Ýlk çaðrý
            ChangeTextsAsync(Color.Cyan, "birinci", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.LightYellow, "birinci", 500); // Senaryo 2

            // Ýkinci çaðrý
            ChangeTextsAsync(Color.Yellow, "ikinci", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.Yellow, "ikinci", 1000); // Senaryo 2

            // Üçüncü çaðrý
            ChangeTextsAsync(Color.Orange, "üçüncü", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.Orange, "ikinci", 1000); // Senaryo 2

            // Dördüncü çaðrý
            ChangeTextsAsync(Color.Red, "dördüncü", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.Red, "ikinci", 1000); // Senaryo 2
        }

        private void ChangeTexts(Color color, string text)
        {
            // Uzun süren iþlemleri burada simüle ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus1.Text = $"Senkron metot çalýþtý ve {text} adým iþlendi.";
            lblStatus1.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus2.Text = $"Senkron metot çalýþtý ve {text} adým iþlendi.";
            lblStatus2.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus3.Text = $"Senkron metot çalýþtý ve {text} adým iþlendi.";
            lblStatus3.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus4.Text = $"Senkron metot çalýþtý ve {text} adým iþlendi.";
            lblStatus4.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus5.Text = $"Senkron metot çalýþtý ve {text} adým iþlendi.";
            lblStatus5.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus6.Text = $"Senkron metot çalýþtý ve {text} adým iþlendi.";
            lblStatus6.ForeColor = color;
        }

        private async Task ChangeTextsAsync(Color color, string text, int delay)
        {
            // Uzun süren iþlemleri burada simüle ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus1.Text =  $"Asenkron metot çalýþtý ve {text} adým yeniden iþlendi.";
            lblStatus1.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus2.Text = $"Asenkron metot çalýþtý ve {text} adým yeniden iþlendi.";
            lblStatus2.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus3.Text = $"Asenkron metot çalýþtý ve {text} adým yeniden iþlendi.";
            lblStatus3.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus4.Text = $"Asenkron metot çalýþtý ve {text} adým yeniden iþlendi.";
            lblStatus4.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus5.Text = $"Asenkron metot çalýþtý ve {text} adým yeniden iþlendi.";
            lblStatus5.ForeColor = color;

            // Uzun süren iþlemleri burada simüle ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus6.Text = $"Asenkron metot çalýþtý ve {text} adým yeniden iþlendi.";
            lblStatus6.ForeColor = color;
        }
    }
}