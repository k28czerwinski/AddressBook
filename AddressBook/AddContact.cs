using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public partial class AddContact : Form
    {
        private const int WS_MINIMIZEBOX = 0x20000;

        private const int CS_DBLCLKS = 0x8;

        int WindowMove;

        int WindowLocationX;

        int WindowLocationY;

        public static List<string> newContact = new List<string>();

        public AddContact()
        {
            InitializeComponent();

            ActiveControl = InputValue;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.Style |= WS_MINIMIZEBOX;

                cp.ClassStyle |= CS_DBLCLKS;

                return cp;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (askInput.Text == "Wprowadź imię użytkownika:")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text))
                    {
                        newContact.Clear();

                        askInput.Text = "Wprowadź nazwisko użytkownika:";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 7 / 8";

                        newContact.Add(InputValue.Text);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź nazwisko użytkownika:")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text))
                    {
                        askInput.Text = "Wprowadź wiek użytkownika: (format 00)";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 6 / 8";

                        newContact.Add(InputValue.Text);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź wiek użytkownika: (format 00)")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text) && Regex.IsMatch(InputValue.Text, @"^\d+$"))
                    {
                        askInput.Text = "Wprowadź płeć użytkownika: (Mężczyzna/Kobieta)";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 5 / 8";

                        newContact.Add(InputValue.Text);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź płeć użytkownika: (Mężczyzna/Kobieta)")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text) && ((InputValue.Text.Trim() == "Mężczyzna") == true | (InputValue.Text.Trim() == "Kobieta") == true))
                    {
                        askInput.Text = "Wprowadź kod pocztowy użytkownika: (format 00000)";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 4 / 8";

                        newContact.Add(InputValue.Text);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź kod pocztowy użytkownika: (format 00000)")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text) && (InputValue.Text.Trim().Length == 5) == true && Regex.IsMatch(InputValue.Text, @"^\d+$"))
                    {
                        askInput.Text = "Wprowadź miasto użytkownika:";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 3 / 8";

                        string readyPost = null;

                        for (int i = 0; i < InputValue.Text.Trim().Length; i++)
                        {
                            readyPost += InputValue.Text[i];

                            if (i == 1)
                            {
                                readyPost += "-";
                            }
                        }

                        newContact.Add(readyPost);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź miasto użytkownika:")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text))
                    {
                        askInput.Text = "Wprowadź ulicę użytkownika:";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 2 / 8";

                        newContact.Add(InputValue.Text);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź ulicę użytkownika:")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text))
                    {
                        askInput.Text = "Wprowadź numer domu użytkownika:";

                        informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 1 / 8";

                        newContact.Add(InputValue.Text);

                        InputValue.Clear();

                        InputValue.Focus();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }

                else if (askInput.Text == "Wprowadź numer domu użytkownika:")
                {
                    if (!string.IsNullOrWhiteSpace(InputValue.Text) && Regex.IsMatch(InputValue.Text, @"\d"))
                    {
                        newContact.Add(InputValue.Text);

                        this.Close();
                    }

                    else
                    {
                        Navigate.ToolTipTitle = "Informacja";

                        Navigate.ToolTipIcon = ToolTipIcon.Warning;

                        Navigate.Show("Uzupełnij informację prawidłowo!", InputTheme, 5, InputTheme.Height - 5, 1500);

                        InputValue.Focus();
                    }
                }
            }

            catch
            {
                //błąd dodawania kontaktu
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow.checkPosible = true;

                this.Close();
            }

            catch
            {
                //błąd zamykania okna
            }
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            informationInput.Text = "Wymaganych informacji do utworzenia kontaktu: 8 / 8";

            askInput.Text = "Wprowadź imię użytkownika:";

            ToolTip UserInformation = new ToolTip();

            UserInformation.SetToolTip(okButton, "Zatwierdź wprowadzone dane");

            UserInformation.SetToolTip(CancelActionButton, "Anuluj dodawanie kontaktu");
        }

        private void WindowBorder_MouseUp(object sender, MouseEventArgs e)
        {
            WindowMove = 0;
        }

        private void WindowBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowMove == 1)
            {
                SetDesktopLocation(MousePosition.X - WindowLocationX, MousePosition.Y - WindowLocationY);
            }
        }

        private void WindowBorder_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove = 1; WindowLocationX = e.X; WindowLocationY = e.Y;
        }

        private void InputTheme_Click(object sender, EventArgs e)
        {
            InputValue.Focus();
        }

        private void InputValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }

        private void AddContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newContact.Count < 8)
            {
                MainWindow.checkPosible = true;
            }
        }
    }
}
