using System;
using System.Windows.Forms;

namespace kana_train
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void start_hiragana_button_Click(object sender, EventArgs e)
        {
            kana_train_form temp_form = new kana_train_form(0);
            Hide();
            temp_form.ShowDialog(this);
            temp_form.Dispose();
            Show();
                    
        }

        private void start_katakana_button_Click(object sender, EventArgs e)
        {
            kana_train_form temp_form = new kana_train_form(1);
            Hide();
            temp_form.ShowDialog(this);
            Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_menu_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("1");
            if (e.KeyCode == Keys.Escape)
            {
                Console.WriteLine("2");
                Application.Exit();
            }
            
        }
    }
}
