using System;
using System.Linq;
using System.Windows.Forms;

namespace kana_train
{
    public partial class kana_train_form : Form
    {
        public Random rand = new Random();
        public int rand_int = 0;
        public int pre_rand_int = 0;
        private int kana_choice = 0;
        private string[] sound_array = new string[] { };
        private string[] regular_sound_array = new string[] {
        "A",    "I",    "U",    "E",    "O",
        "KA",   "KI",   "KU",   "KE",   "KO",
        "SA",   "SHI",  "SU",   "SE",   "SO",
        "TA",   "CHI",  "TSU",  "TE",   "TO",
        "NA",   "NI",   "NU",   "NE",   "NO",
        "HA",   "HI",   "FU",   "HE",   "HO",
        "MA",   "MI",   "MU",   "ME",   "MO",
        "YA",           "YU",           "YO",
        "RA",   "RI",   "RU",   "RE",   "RO",
        "WA",                           "WO",
        "N"};

        private string[] dakuten_sound_array = new string[] {
        "GA",   "GI",   "GU",   "GE",   "GO",
        "ZA",   "JI",   "ZU",   "ZE",   "ZO",
        "DA",   "JI*",  "ZU*",  "DE",   "DO",
        "BA",   "BI",   "BU",   "BE",   "BO",
        "PA",   "PI",   "PU",   "PE",   "PO"};

        private string[] combination_sound_array = new string[] {
        "KYA",      "KYU",     "KYO",
        "SHA",      "SHU",     "SHO",
        "CHA",      "CHU",     "CHO",
        "NYA",      "NYU",     "NYO",
        "HYA",      "HYU",     "HYO",
        "MYA",      "MYU",     "MYO",
        "RYA",      "RYU",     "RYO",
        "GYA",      "GYU",     "GYO",
        "JA",       "JU",      "JO",
        "BYA",      "BYU",     "BYO",
        "PYA",      "PYU",     "PYO"};

        public kana_train_form(int param)
        {
            kana_choice = param;
            sound_array = regular_sound_array.Concat(dakuten_sound_array.Concat(combination_sound_array)).ToArray();
            rand_int = rand.Next(sound_array.Length);
            InitializeComponent();
            main_lable.Visible = true;
            katakana_panel.Visible = false;
            hiragana_panel.Visible = false;
        }

        private void kana_train_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else
            {
                if (e.Control)
                {
                    if (e.KeyCode == Keys.H)
                    {
                        change_help_msg_state();
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                    {
                        if (katakana_panel.Visible || hiragana_panel.Visible)
                        {
                            change_help_msg_state();
                        }
                        main_lable.Visible = true;
                        pre_rand_int = rand_int;
                        rand_int = rand.Next(sound_array.Length);
                        main_lable.Text = sound_array[rand_int];

                    }
                    if (e.KeyCode == Keys.Back)
                    {
                        if (!katakana_panel.Visible || !hiragana_panel.Visible)
                        {
                            change_help_msg_state();
                        }
                        main_lable.Visible = true;
                        main_lable.Text = sound_array[pre_rand_int];

                    }
                }
            }
        }

        private void change_help_msg_state()
        {
            main_lable.Visible = !main_lable.Visible;
            if (kana_choice == 0)
            {
                hiragana_panel.Visible = !hiragana_panel.Visible;

            }
            else
            {
                katakana_panel.Visible = !katakana_panel.Visible;

            }
        }
    }
}
