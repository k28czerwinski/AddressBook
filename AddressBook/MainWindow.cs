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

namespace AddressBook
{
    public partial class MainWindow : Form
    {
        #region Dane

        private const int WS_MINIMIZEBOX = 0x20000;

        private const int CS_DBLCLKS = 0x8;

        int WindowMove;

        int WindowLocationX;

        int WindowLocationY;

        Thread LoadData;

        Thread LoadFileDirectory;

        List<string> copyOfContacts = new List<string>();

        public static string DirectoryApp = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);

        public static bool checkPosible = false;

        public static bool checkStatus = false;

        public static string actualValue = null;

        public static int EditRowIndex;

        public static int EditColumnIndex;

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Custom Form - nadpisanie funkcji minimalizacji z Tray

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

        #endregion

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region Custom Form - poruszanie oknem

        private void UpBelt_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowMove == 1)
            {
                SetDesktopLocation(MousePosition.X - WindowLocationX, MousePosition.Y - WindowLocationY);
            }
        }

        private void UpBelt_MouseUp(object sender, MouseEventArgs e)
        {
            WindowMove = 0;
        }

        private void UpBelt_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove = 1; WindowLocationX = e.X; WindowLocationY = e.Y;
        }

        #endregion

        private void SearcherTheme_Click(object sender, EventArgs e)
        {
            InputSearcher.Focus();
        }

        private void readDataFromFile()
        {
            try
            {
                using (StreamReader loadedValue = new StreamReader($@"{DirectoryApp}\contact.txt"))
                {
                    List<string> AllValues = new List<string>();

                    while (true)
                    {
                        if (loadedValue.EndOfStream)
                        {
                            break;
                        }

                        string Line = loadedValue.ReadLine();

                        AllValues.Add(Line.Trim());
                    }

                    AllValues = AllValues.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

                    this.Invoke((MethodInvoker)delegate
                    {
                        for (int i = 0; i < AllValues.Count; i++)
                        {
                            string[] DivideValue = AllValues[i].Split('|');

                            ContactsTable.Rows.Add($"{DivideValue[0]}", $"{DivideValue[1]}", $"{DivideValue[2]}", $"{DivideValue[3]}", $"{DivideValue[4]}", $"{DivideValue[5]}", $"{DivideValue[6]}", $"{DivideValue[7]}");
                        }

                        ContactsTable.Rows.Add("", "", "", "", "", "", "", "");

                        int tableRow = ContactsTable.Rows.Count - 1;

                        ContactsTable.Rows[tableRow].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);

                        ContactsTable.ClearSelection();
                    });

                    try
                    {
                        copyOfContacts.Clear();

                        int contactCount = ContactsTable.Rows.Count;

                        string ReadyContact = null;

                        for (int i = 0; i < contactCount - 1; i++)
                        {
                            ReadyContact = null;

                            for (int j = 0; j < 8; j++)
                            {
                                ReadyContact += ContactsTable.Rows[i].Cells[j].Value.ToString() + "|";
                            }

                            copyOfContacts.Add(ReadyContact);
                        }
                    }

                    catch
                    {
                        //błąd tworzenia kopii kontaktów
                    }
                }
            }

            catch
            {
                //błąd odczytu pliku
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData = new Thread(readDataFromFile);

                LoadData.Start();
            }

            catch
            {
                //błąd załadowania wątku
            }

            ToolTip UserInformation = new ToolTip();

            UserInformation.SetToolTip(deleteContact, "Zaznacz kontakt w tabeli następnie usuń");

            UserInformation.SetToolTip(addContact, "Dodan nowy kontakt");

            UserInformation.SetToolTip(editContact, "Zaznacz kontakt w tabeli następnie edytuj");

            UserInformation.SetToolTip(openFileWithContacts, "Otwórz lokację, w której znajduje się plik z kontaktami");

            UserInformation.SetToolTip(saveAll, "Zapisz wszystkie zmiany");

            UserInformation.SetToolTip(MinimizeButton, "Minimalizuj okno");

            UserInformation.SetToolTip(ExitButton, "Zamknij aplikację");

            UserInformation.SetToolTip(restartApplication, "Zrestartuj aplikację");

            #region przykładowe kontakty

            //ContactsTable.Rows.Add("Jan", "Kowalski", "45", "Mężczyzna", "62-270", "Poznań", "Czekoladowa", "42");

            //ContactsTable.Rows.Add("Damian", "Czerwiński", "22", "Mężczyzna", "61-619", "Wrocław", "Szkolna", "3A/4");

            //ContactsTable.Rows.Add("Paweł", "Nieznany", "31", "Mężczyzna", "43-451", "Warszawa", "Drogowa", "2C");

            //ContactsTable.Rows.Add("Weronika", "Jakaś", "19", "Kobieta", "20-123", "Konin", "Wiejska", "13");  

            #endregion
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            try
            {
                checkPosible = false;

                AddContact Window = new AddContact();

                DialogResult Check = Window.ShowDialog();

                if (checkPosible == false)
                {
                    List<string> readyValues = AddContact.newContact;

                    InputSearcher.Clear();

                    #region Pobieranie starwej wersji tabeli

                    List<string> oldValues = new List<string>();

                    int contactCount = ContactsTable.Rows.Count;

                    string ReadyContact = null;

                    for (int i = 0; i < contactCount - 1; i++)
                    {
                        ReadyContact = null;

                        for (int j = 0; j < 8; j++)
                        {
                            ReadyContact += ContactsTable.Rows[i].Cells[j].Value.ToString() + "|";
                        }

                        oldValues.Add(ReadyContact);
                    }

                    #endregion

                    ContactsTable.Rows.Clear();

                    #region Dodawanie nowych komórek do tabeli

                    for (int i = 0; i < oldValues.Count; i++)
                    {
                        string[] DivideValue = oldValues[i].Split('|');

                        ContactsTable.Rows.Add($"{DivideValue[0]}", $"{DivideValue[1]}", $"{DivideValue[2]}", $"{DivideValue[3]}", $"{DivideValue[4]}", $"{DivideValue[5]}", $"{DivideValue[6]}", $"{DivideValue[7]}");
                    }

                    ContactsTable.Rows.Add($"{readyValues[0]}", $"{readyValues[1]}", $"{readyValues[2]}", $"{readyValues[3]}", $"{readyValues[4]}", $"{readyValues[5]}", $"{readyValues[6]}", $"{readyValues[7]}");

                    ContactsTable.Rows.Add("", "", "", "", "", "", "", "");

                    int tableRow = ContactsTable.Rows.Count - 1;

                    ContactsTable.Rows[tableRow].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);

                    ContactsTable.ClearSelection();

                    #endregion

                    #region Nadpisywanie kopii komórek

                    try
                    {
                        copyOfContacts.Clear();

                        int contactCountCopy = ContactsTable.Rows.Count;

                        string ReadyContactCopy = null;

                        for (int i = 0; i < contactCountCopy - 1; i++)
                        {
                            ReadyContactCopy = null;

                            for (int j = 0; j < 8; j++)
                            {
                                ReadyContactCopy += ContactsTable.Rows[i].Cells[j].Value.ToString() + "|";
                            }

                            copyOfContacts.Add(ReadyContactCopy);
                        }
                    }

                    catch
                    {
                        //błąd tworzenia kopii kontaktów
                    }

                    #endregion
                }
            }

            catch
            {
                //błąd
            }
        }

        private void editContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContactsTable.GetCellCount(DataGridViewElementStates.Selected) > 1 == false &&
                    !string.IsNullOrWhiteSpace(ContactsTable.CurrentCell.Value.ToString()) &&
                    ContactsTable.SelectedCells.Count != 0)
                {
                    actualValue = ContactsTable.CurrentCell.Value.ToString();

                    checkStatus = false;

                    for (int i = 0; i < ContactsTable.GetCellCount(DataGridViewElementStates.Selected); i++)
                    {
                        EditRowIndex = ContactsTable.SelectedCells[i].RowIndex;

                        EditColumnIndex = ContactsTable.SelectedCells[i].ColumnIndex;
                    }

                    List<string> wholeValues = new List<string>();

                    List<string> oldValues = new List<string>();

                    wholeValues.Clear();

                    oldValues.Clear();

                    string readyRow = null;

                    for (int i = 0; i < ContactsTable.GetCellCount(DataGridViewElementStates.Selected); i++)
                    {
                        int rowIndex = ContactsTable.SelectedCells[i].RowIndex;

                        for (int j = 0; j < 8; j++)
                        {
                            readyRow += ContactsTable.Rows[rowIndex].Cells[j].Value.ToString() + "|";
                        }

                        wholeValues.Add(readyRow);

                        readyRow = null;
                    }

                    EditContact Window = new EditContact();

                    DialogResult Check = Window.ShowDialog();

                    try
                    {
                        if (checkStatus == false)
                        {
                            ContactsTable.CurrentCell.Value = EditContact.readyValue;

                            #region Pobieranie aktualnej wersji tabeli                           

                            int contactCount = ContactsTable.Rows.Count;

                            string ReadyContact = null;

                            for (int i = 0; i < contactCount - 1; i++)
                            {
                                ReadyContact = null;

                                for (int j = 0; j < 8; j++)
                                {
                                    ReadyContact += ContactsTable.Rows[i].Cells[j].Value.ToString() + "|";
                                }

                                oldValues.Add(ReadyContact);
                            }

                            #endregion

                            for (int i = 0; i < oldValues.Count; i++)
                            {
                                for (int j = 0; j < copyOfContacts.Count; j++)
                                {
                                    if (copyOfContacts[j].Trim() == wholeValues[0].Trim())
                                    {
                                        for (int k = 0; k < oldValues.Count; k++)
                                        {
                                            copyOfContacts[j] = oldValues[EditRowIndex];
                                        }
                                    }
                                }
                            }
                        }
                    }

                    catch
                    {

                    }                  
                }

                else
                {
                    Navigate.ToolTipTitle = "Informacja";

                    Navigate.ToolTipIcon = ToolTipIcon.Warning;

                    Navigate.Show("Zaznacz jedną komórkę w tabeli!", backgroundTip, 5, backgroundTip.Height - 5, 2500);
                }
            }

            catch
            {
                //błąd edytowania komórek
            }
        }

        private void sortContacts_Click(object sender, EventArgs e)
        {
            try
            {
                LoadFileDirectory = new Thread(showFolder);

                LoadFileDirectory.Start();
            }

            catch
            {
                //błąd startu wątku 
            }
        }

        private void showFolder()
        {
            try
            {
                ProcessStartInfo Explorer = new ProcessStartInfo();

                Explorer.FileName = "explorer.exe";

                Explorer.Arguments = $@"{DirectoryApp}";

                Process show = new Process();

                show.StartInfo = Explorer;

                show.StartInfo.CreateNoWindow = true;

                show.StartInfo.UseShellExecute = false;

                show.StartInfo.RedirectStandardOutput = true;

                show.Start();

                show.WaitForExit();
            }

            catch
            {
                //błąd wskazania ścieżki folderu
            }
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> tableValues = new List<string>();

                InputSearcher.Clear();

                int contactCount = ContactsTable.Rows.Count;

                string ReadyContact = null;

                for (int i = 0; i < contactCount - 1; i++)
                {
                    ReadyContact = null;

                    for (int j = 0; j < 8; j++)
                    {
                        ReadyContact += ContactsTable.Rows[i].Cells[j].Value.ToString() + "|";
                    }

                    tableValues.Add(ReadyContact);
                }

                using (StreamWriter saveFile = new StreamWriter($@"{DirectoryApp}\contact.txt"))
                {
                    foreach (var Value in tableValues)
                    {
                        saveFile.WriteLine(Value.ToString() + Environment.NewLine);
                    }
                }

                Navigate.ToolTipTitle = "Informacja";

                Navigate.ToolTipIcon = ToolTipIcon.Info;

                Navigate.Show("Zapisano listę kontaktów.", saveAll, 5, saveAll.Height - 5, 1500);
            }

            catch
            {
                Navigate.ToolTipTitle = "Informacja";

                Navigate.ToolTipIcon = ToolTipIcon.Error;

                Navigate.Show("Błąd podczas zapisu!", saveAll, 5, saveAll.Height - 5, 2000);
            }
        }

        private void InputSearcher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Word = InputSearcher.Text.Trim();

                ContactsTable.Rows.Clear();

                if (!string.IsNullOrWhiteSpace(Word))
                {
                    foreach (string Value in copyOfContacts)
                    {
                        if (Value.ToLower().Contains(Word.ToLower()))
                        {
                            string[] RowValue = Value.Split('|');

                            ContactsTable.Rows.Add($"{RowValue[0]}", $"{RowValue[1]}", $"{RowValue[2]}", $"{RowValue[3]}", $"{RowValue[4]}", $"{RowValue[5]}", $"{RowValue[6]}", $"{RowValue[7]}");
                        }
                    }

                    try
                    {
                        ContactsTable.Rows.Add("", "", "", "", "", "", "", "");

                        int tableRow = ContactsTable.Rows.Count - 1;

                        ContactsTable.Rows[tableRow].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);

                        ContactsTable.ClearSelection();
                    }

                    catch
                    {
                        //błąd rysowania komórki
                    }
                }

                else
                {
                    foreach (string Value in copyOfContacts)
                    {
                        string[] RowValue = Value.Split('|');

                        ContactsTable.Rows.Add($"{RowValue[0]}", $"{RowValue[1]}", $"{RowValue[2]}", $"{RowValue[3]}", $"{RowValue[4]}", $"{RowValue[5]}", $"{RowValue[6]}", $"{RowValue[7]}");
                    }

                    try
                    {
                        ContactsTable.Rows.Add("", "", "", "", "", "", "", "");

                        int tableRow = ContactsTable.Rows.Count - 1;

                        ContactsTable.Rows[tableRow].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);

                        ContactsTable.ClearSelection();
                    }

                    catch
                    {
                        //błąd rysowania komórki
                    }
                }
            }

            catch
            {
                //błąd wyszukiwania podanej frazy
            }
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            if (ContactsTable.SelectedCells.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(ContactsTable.CurrentCell.Value.ToString()))
                {
                    try
                    {
                        #region Pobieranie zaznaczonych komórek (jako cała wartość tabeli) + tworzenie zmiennych zaznaczonych

                        List<string> wholeValues = new List<string>();

                        string readyRow = null;

                        for (int i = 0; i < ContactsTable.GetCellCount(DataGridViewElementStates.Selected); i++)
                        {
                            int rowIndex = ContactsTable.SelectedCells[i].RowIndex;

                            for (int j = 0; j < 8; j++)
                            {
                                readyRow += ContactsTable.Rows[rowIndex].Cells[j].Value.ToString() + "|";
                            }

                            wholeValues.Add(readyRow);

                            readyRow = null;
                        }

                        #endregion

                        #region Pobieranie całej aktualnej tabeli (komórki widocznej w czasie edycji) 

                        List<string> oldValues = new List<string>();

                        int contactCount = ContactsTable.Rows.Count;

                        string ReadyContact = null;

                        for (int i = 0; i < contactCount - 1; i++)
                        {
                            ReadyContact = null;

                            for (int j = 0; j < 8; j++)
                            {
                                ReadyContact += ContactsTable.Rows[i].Cells[j].Value.ToString() + "|";
                            }

                            oldValues.Add(ReadyContact);
                        }

                        for (int i = 0; i < wholeValues.Count; i++)
                        {
                            for (int j = 0; j < oldValues.Count; j++)
                            {
                                if (oldValues[j].Trim() == wholeValues[i].Trim())
                                {
                                    oldValues.RemoveAt(j);
                                }
                            }
                        }

                        ContactsTable.Rows.Clear();

                        for (int i = 0; i < oldValues.Count; i++)
                        {
                            string[] RowValue = oldValues[i].Split('|');

                            ContactsTable.Rows.Add($"{RowValue[0]}", $"{RowValue[1]}", $"{RowValue[2]}", $"{RowValue[3]}", $"{RowValue[4]}", $"{RowValue[5]}", $"{RowValue[6]}", $"{RowValue[7]}");
                        }

                        try
                        {
                            ContactsTable.Rows.Add("", "", "", "", "", "", "", "");

                            int tableRow = ContactsTable.Rows.Count - 1;

                            ContactsTable.Rows[tableRow].DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);

                            ContactsTable.ClearSelection();
                        }

                        catch
                        {
                            //błąd rysowania komórki
                        }

                        #endregion

                        #region Usuwanie wartości głównej kopi danych [copyOfContacts]

                        for (int i = 0; i < wholeValues.Count; i++)
                        {
                            for (int j = 0; j < copyOfContacts.Count; j++)
                            {
                                if (copyOfContacts[j].Trim() == wholeValues[i].Trim())
                                {
                                    copyOfContacts.RemoveAt(j);
                                }
                            }
                        }
                        #endregion
                    }

                    catch
                    {
                        //Błąd usuwania danych
                    }
                }

                else
                {
                    Navigate.ToolTipTitle = "Informacja";

                    Navigate.ToolTipIcon = ToolTipIcon.Warning;

                    Navigate.Show("Zaznacz komórki w tabeli!", backgroundTip, 5, backgroundTip.Height - 5, 2500);
                }
            }

            else
            {
                Navigate.ToolTipTitle = "Informacja";

                Navigate.ToolTipIcon = ToolTipIcon.Warning;

                Navigate.Show("Zaznacz komórki w tabeli!", backgroundTip, 5, backgroundTip.Height - 5, 2500);
            }
        }

        private void restartApplication_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start($@"{DirectoryApp}\AddressBook.exe");

                Environment.Exit(0);
            }

            catch
            {
                //Błąd
            }
        }
    }
}
