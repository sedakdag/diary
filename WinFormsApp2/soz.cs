using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;  // WebView2 namespace'ini ekleyin

namespace WinFormsApp2
{
    public partial class soz : Form
    {
        public soz()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde WebView2'yi başlat
        private async void soz_Load(object sender, EventArgs e)
        {
            // WebView2'yi başlatma
            await webView21.EnsureCoreWebView2Async(null);

            // Web sayfasını yükleme
            webView21.Source = new Uri("https://www.brainyquote.com/quote_of_the_day");
        }

        // WebView2 kontrolü tıklama olayına ihtiyacınız varsa buraya ekleyebilirsiniz
        private void webView21_Click(object sender, EventArgs e)
        {
            // Tıklama işlevi eklemek isterseniz
        }

        // Buton tıklama olayını aşağıdaki gibi kullanabilirsiniz
        private void button1_Click(object sender, EventArgs e)
        {
            // Button tıklanmasıyla yeni bir sayfa yükleyebiliriz
            webView21.Source = new Uri("https://www.brainyquote.com/quote_of_the_day");
        }
    }
}
