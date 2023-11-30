using Newtonsoft.Json;
using System.Text;

namespace Maket
{
    public partial class Form1 : Form
    {
        List<TextBox> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<TextBox>();
            list.Add(textBox);
        }

        private void URL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Width = 200;
            newTextBox.Location = new Point(124, list.Last().Location.Y + 50);
            list.Add(newTextBox);
            this.Controls.Add(newTextBox);
        }

        private async void BtnSend_ClickAsync(object sender, EventArgs e)
        {
            Departments newList = new Departments();

            foreach (TextBox tb in list)
            {
                newList.department.Add(tb.Text);
            }

            HttpClient client = new HttpClient();

            string stringJson = JsonConvert.SerializeObject(newList);

            HttpContent content = new StringContent(stringJson, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url.Text, content);

            if (response.IsSuccessStatusCode)
            {
                string resposeContent = await response.Content.ReadAsStringAsync();

                MessageBox.Show(resposeContent);
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к серверу");
            }
        }
    }
}