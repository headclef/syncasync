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
            // �lk �a�r�
            ChangeTexts(Color.LightGreen, "birinci");

            // �kinci �a�r�
            ChangeTexts(Color.Green, "ikinci");

            // ���nc� �a�r�
            ChangeTexts(Color.DarkGreen, "���nc�");
        }

        private async void btnAsenkron_Click(object sender, EventArgs e)
        {
            // �lk �a�r�
            ChangeTextsAsync(Color.Cyan, "birinci", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.LightYellow, "birinci", 500); // Senaryo 2

            // �kinci �a�r�
            ChangeTextsAsync(Color.Yellow, "ikinci", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.Yellow, "ikinci", 1000); // Senaryo 2

            // ���nc� �a�r�
            ChangeTextsAsync(Color.Orange, "���nc�", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.Orange, "ikinci", 1000); // Senaryo 2

            // D�rd�nc� �a�r�
            ChangeTextsAsync(Color.Red, "d�rd�nc�", 500); // Senaryo 1
            //await ChangeTextsAsync(Color.Red, "ikinci", 1000); // Senaryo 2
        }

        private void ChangeTexts(Color color, string text)
        {
            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus1.Text = $"Senkron metot �al��t� ve {text} ad�m i�lendi.";
            lblStatus1.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus2.Text = $"Senkron metot �al��t� ve {text} ad�m i�lendi.";
            lblStatus2.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus3.Text = $"Senkron metot �al��t� ve {text} ad�m i�lendi.";
            lblStatus3.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus4.Text = $"Senkron metot �al��t� ve {text} ad�m i�lendi.";
            lblStatus4.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus5.Text = $"Senkron metot �al��t� ve {text} ad�m i�lendi.";
            lblStatus5.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            Thread.Sleep(500); // 2 saniye bekletiyoruz.

            lblStatus6.Text = $"Senkron metot �al��t� ve {text} ad�m i�lendi.";
            lblStatus6.ForeColor = color;
        }

        private async Task ChangeTextsAsync(Color color, string text, int delay)
        {
            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus1.Text =  $"Asenkron metot �al��t� ve {text} ad�m yeniden i�lendi.";
            lblStatus1.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus2.Text = $"Asenkron metot �al��t� ve {text} ad�m yeniden i�lendi.";
            lblStatus2.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus3.Text = $"Asenkron metot �al��t� ve {text} ad�m yeniden i�lendi.";
            lblStatus3.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus4.Text = $"Asenkron metot �al��t� ve {text} ad�m yeniden i�lendi.";
            lblStatus4.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus5.Text = $"Asenkron metot �al��t� ve {text} ad�m yeniden i�lendi.";
            lblStatus5.ForeColor = color;

            // Uzun s�ren i�lemleri burada sim�le ediyoruz.
            await Task.Delay(delay); // Senaryo 1
            //await Task.Delay(2000); // Senaryo 2

            lblStatus6.Text = $"Asenkron metot �al��t� ve {text} ad�m yeniden i�lendi.";
            lblStatus6.ForeColor = color;
        }
    }
}