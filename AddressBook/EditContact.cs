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
    public partial class EditContact : Form
    {
        private const int WS_MINIMIZEBOX = 0x20000;

        private const int CS_DBLCLKS = 0x8;

        int WindowMove;

        int WindowLocationX;

        int WindowLocationY;

        public static string readyValue;

        public EditContact()
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

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainWindow.checkStatus = true;

                this.Close();
            }

            catch
            {
                //błąd zamykania okna
            }
        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            ToolTip UserInformation = new ToolTip();

            UserInformation.SetToolTip(okButton, "Zatwierdź wprowadzone dane");

            UserInformation.SetToolTip(CancelActionButton, "Anuluj dodawanie kontaktu");

            InputValue.Text = MainWindow.actualValue;

            readyValue = null;

            if (MainWindow.EditColumnIndex == 0)
            {
                askInput.Text = "Wprowadź nowe imię użytkownika:";

                informationInput.Text = "Edytujesz wartość 'IMIĘ'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 1)
            {
                askInput.Text = "Wprowadź nowe nazwisko użytkownika:";

                informationInput.Text = "Edytujesz wartość 'NAZWISKO'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 2)
            {
                askInput.Text = "Wprowadź nowy wiek użytkownika: (format 00)";

                informationInput.Text = "Edytujesz wartość 'WIEK'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 3)
            {
                askInput.Text = "Wprowadź nową płeć użytkownika: (Mężczyzna/Kobieta)";

                informationInput.Text = "Edytujesz wartość 'PŁEĆ'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 4)
            {
                askInput.Text = "Wprowadź nowy kod pocztowy użytkownika: (format 00000)";

                informationInput.Text = "Edytujesz wartość 'KOD POCZTOWY'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 5)
            {
                askInput.Text = "Wprowadź nowe miasto użytkownika:";

                informationInput.Text = "Edytujesz wartość 'MIASTO'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 6)
            {
                askInput.Text = "Wprowadź nową ulicę użytkownika:";

                informationInput.Text = "Edytujesz wartość 'ULICA'. Wymagane informacje: 1 / 1";
            }

            else if (MainWindow.EditColumnIndex == 6)
            {
                askInput.Text = "Wprowadź nowy numer domu użytkownika:";

                informationInput.Text = "Edytujesz wartość 'NUMER DOMU'. Wymagane informacje: 1 / 1";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (MainWindow.EditColumnIndex == 0)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text))
                {
                    readyValue = InputValue.Text.Trim();

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

            else if (MainWindow.EditColumnIndex == 1)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text))
                {
                    readyValue = InputValue.Text.Trim();

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

            else if (MainWindow.EditColumnIndex == 2)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text) && Regex.IsMatch(InputValue.Text, @"^\d+$"))
                {
                    readyValue = InputValue.Text.Trim();

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

            else if (MainWindow.EditColumnIndex == 3)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text) && ((InputValue.Text.Trim() == "Mężczyzna") == true | (InputValue.Text.Trim() == "Kobieta") == true))
                {
                    readyValue = InputValue.Text.Trim();

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

            else if (MainWindow.EditColumnIndex == 4)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text) && (InputValue.Text.Trim().Length == 5) == true && Regex.IsMatch(InputValue.Text.Trim(), @"^\d+$"))
                {
                    string readyPost = null;

                    for (int i = 0; i < InputValue.Text.Trim().Length; i++)
                    {
                        readyPost += InputValue.Text[i];

                        if (i == 1)
                        {
                            readyPost += "-";
                        }
                    }

                    readyValue = readyPost;

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

            else if (MainWindow.EditColumnIndex == 5)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text))
                {
                    readyValue = InputValue.Text.Trim();

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

            else if (MainWindow.EditColumnIndex == 6)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text))
                {
                    readyValue = InputValue.Text.Trim();

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

            else if (MainWindow.EditColumnIndex == 7)
            {
                if (!string.IsNullOrWhiteSpace(InputValue.Text) && Regex.IsMatch(InputValue.Text, @"\d"))
                {
                    readyValue = InputValue.Text.Trim();

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

        private void InputTheme_Click(object sender, EventArgs e)
        {
            InputValue.Focus();
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

        private void EditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(readyValue))
            {
                MainWindow.checkStatus = true;
            }
        }

        private void InputValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }
}
