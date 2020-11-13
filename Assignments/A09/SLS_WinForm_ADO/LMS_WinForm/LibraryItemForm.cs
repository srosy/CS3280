using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LMS_WinForm
{
    public partial class formSLS : Form
    {
        private readonly int FRAME_WIDTH;
        private readonly int FRAME_HEIGHT;
        private Point START_POINT;
        private const int COL_CONTROL_SPACING = 10;
        private const int ROW_CONTROL_SPACING = 25;
        private const int TB_CONTROL_WIDTH = 200;
        private const int LBL_CONTROL_WIDTH = 200;
        private Control previous;
        private string SelectedLibraryItemType;

        int CurrentRowPoint { get; set; }

        public formSLS()
        {
            InitializeComponent();
            pnl.BackColor = Color.White;
            pnl.BorderStyle = BorderStyle.FixedSingle;
            cmbItemType.SelectedIndex = 0;
            cmbItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbCloneQuantity.Leave += EnforceQuantity_Leave;
            pnl.ControlAdded += Pnl_ControlAdded;

            FRAME_HEIGHT = this.Height;
            FRAME_WIDTH = this.Width;
            START_POINT = new Point(FRAME_WIDTH / 16, FRAME_HEIGHT / 16);// new Point(10, 10); // cols = x, rows = y (margin)
        }

        #region General Form Setup
        private void SetupLibraryItem()
        {
            RefreshPnl();

            string[] LibraryItemFields = new string[6]
            {
                "Author", "Title", "Publisher", "Genre", "Location", "Type"
            };

            var index = 0;
            LibraryItemFields.ToList().ForEach(f =>
            {
                var label = new Label() { Name = $"lbl{f}", Text = $"{f}:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = index++ == 0 ? START_POINT : NextRowControlPoint() };
                pnl.Controls.Add(label);
                previous = label;
                var textbox = new TextBox() { Name = $"tb{f}", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };

                if (index == LibraryItemFields.Length)
                {
                    textbox.Text = SelectedLibraryItemType;
                    textbox.Enabled = false;
                }

                pnl.Controls.Add(textbox);
                previous = textbox;
            });
        }
        private void SetupEBook()
        {
            SetupBook();

            var lblWebUri = new Label() { Text = "Enter Web Uri:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblWebUri);
            previous = lblWebUri;
            var tbWebUri = new TextBox() { Name = "WebUrl", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbWebUri);
            previous = tbWebUri;
        }
        private void SetupJournal()
        {
            SetupLibraryItem();

            var lblISSN = new Label() { Text = "Enter ISSN #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblISSN);
            previous = lblISSN;
            var tbISSN = new TextBox() { Name = "ISSN", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            tbISSN.Leave += EnforceQuantity_Leave;
            pnl.Controls.Add(tbISSN);
            previous = tbISSN;

            var lblVolumeNum = new Label() { Text = "Enter Volume #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblVolumeNum);
            previous = lblVolumeNum;
            var tbVolumeNum = new TextBox() { Name = "VolumeNum", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            tbVolumeNum.Leave += EnforceQuantity_Leave;
            pnl.Controls.Add(tbVolumeNum);
            previous = tbVolumeNum;
        }
        private void SetupMagazine()
        {
            SetupLibraryItem();

            var lblNumArticles = new Label() { Text = "Enter # of Articles:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblNumArticles);
            previous = lblNumArticles;
            var tbNumArticles = new TextBox() { Name = "NumArticles", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            tbNumArticles.Leave += EnforceQuantity_Leave;
            pnl.Controls.Add(tbNumArticles);
            previous = tbNumArticles;

            var lblAdvertisers = new Label() { Text = "Enter an advertiser per line:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblAdvertisers);
            previous = lblAdvertisers;
            var tbAdvertisers = new TextBox() { Name = "Advertisers", Location = NextInlineControlPoint(), Multiline = true, Height = 60, Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbAdvertisers);
            previous = tbAdvertisers;
        }
        private void SetupBook()
        {
            SetupLibraryItem();

            var lblISBN = new Label() { Text = "Enter ISBN #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblISBN);
            previous = lblISBN;
            var tbISBN = new TextBox() { Name = "ISBN", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            tbISBN.Leave += EnforceQuantity_Leave;
            pnl.Controls.Add(tbISBN);
            previous = tbISBN;

            var lblEdition = new Label() { Text = "Enter Edition #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblEdition);
            previous = lblEdition;
            var tbEdition = new TextBox() { Name = "Edition", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            tbEdition.Leave += EnforceQuantity_Leave;
            pnl.Controls.Add(tbEdition);
            previous = tbEdition;
        }
        #endregion

        #region General Form Events
        private void CmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItemType.SelectedIndex > 0)
            {
                SelectedLibraryItemType = cmbItemType.Text;
            }

            if (cmbItemType.SelectedIndex == 1)
            {
                PromptForEbookOrBook();
                lblFormInstructions.Visible = true;
            }
            if (cmbItemType.SelectedIndex == 2)
            {
                SetupMagazine();
                lblFormInstructions.Visible = true;
            }
            if (cmbItemType.SelectedIndex == 3)
            {
                SetupJournal();
                lblFormInstructions.Visible = true;
            }
        }
        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            if (obj.SelectedIndex > 0)
            {
                SelectedLibraryItemType = obj.Text;
            }

            if (obj.SelectedIndex == 1) // book
            {
                SetupBook();

                // setup controls for serialization, only paperbook is seriablizable
                SetupSerialization();
            }
            if (obj.SelectedIndex == 2) // e-book
            {
                SetupEBook();
            }
        }
        private void cbClone_CheckedChanged(object sender, EventArgs e)
        {
            lblCloneQuantity.Visible = cbClone.Checked;
            tbCloneQuantity.Visible = cbClone.Checked;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshPnl();
            cbClone.Checked = false;
            cmbItemType.SelectedIndex = 0;
            lblFormInstructions.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // form validation, I only care to have at least a title and type selection
            if (cmbItemType.SelectedIndex > 0 && pnl.Controls.Count > 0)
            {
                var li = GenItemFromForm();

                if (li is null)
                {
                    throw new Exception("Something went wrong when genereating the item from the form.");
                }

                if (string.IsNullOrEmpty(li.Title))
                {
                    MessageBox.Show("Item must have a title!");
                    return;
                }

                BusinessLayer.Utility.SaveLibraryItem(li, !string.IsNullOrEmpty(tbCloneQuantity.Text) ? int.Parse(tbCloneQuantity.Text) : 1); // passing 1 is required by instructor
                PrintPnlFormInfo();
            }
            else
            {
                MessageBox.Show("Form is invalid.");
            }
        }
        #endregion

        #region Serialization/Deserializaton
        private void SetupSerialization()
        {
            // open file for serialization
            var openForSerializationBtn = new Button() { Text = "Open File For Serialization", Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            openForSerializationBtn.Click += OpenForSerializationBtn_Click;
            pnl.Controls.Add(openForSerializationBtn);
            previous = openForSerializationBtn;

            // tb file path for serialzation
            var tbFilePathForSerialization = new TextBox() { Name = "tbPathForSerialization", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH, Enabled = false };
            pnl.Controls.Add(tbFilePathForSerialization);
            previous = tbFilePathForSerialization;

            // serialize and save button
            var serializeAndSave = new Button() { Text = "Serialize And Save", Location = NextInlineControlPoint() };
            serializeAndSave.Click += SerializeAndSave_Click;
            pnl.Controls.Add(serializeAndSave);
            previous = serializeAndSave;

            // Open File for Deserialization button
            var openFileForDeserializationBtn = new Button() { Text = "Open File For Deserializaton", Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            openFileForDeserializationBtn.Click += OpenFileForDeserializationBtn_Click;
            pnl.Controls.Add(openFileForDeserializationBtn);
            previous = openFileForDeserializationBtn;

            // tb file path for deserialization
            var tbFilePathForDeserialization = new TextBox() { Name = "tbPathForDeserialization", Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH, Enabled = false };
            pnl.Controls.Add(tbFilePathForDeserialization);
            previous = tbFilePathForDeserialization;

            // serialize and save button
            var deserializeAndCreateBtn = new Button() { Text = "Deserialize And Create", Location = NextInlineControlPoint() };
            deserializeAndCreateBtn.Click += DeserializeAndCreateBtn_Click;
            pnl.Controls.Add(deserializeAndCreateBtn);
            previous = deserializeAndCreateBtn;
        }
        private void DeserializeAndCreateBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnl.Controls)
            {
                if (c.Name.Equals("tbPathForDeserialization", StringComparison.OrdinalIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(c.Text))
                    {
                        try
                        {
                            var obj = BusinessLayer.Utility.Deserialize<BusinessLayer.Models.PaperBook>(c.Text);
                            BusinessLayer.Models.PaperBook paperBook = obj;
                            PrintProperties(paperBook);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"{ex.Message}");
                        }
                    }
                }
            }
        }
        private void OpenFileForDeserializationBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                foreach (Control c in pnl.Controls)
                {
                    if (c.Name.Equals("tbPathForDeserialization", StringComparison.OrdinalIgnoreCase))
                    {
                        c.Text = ofd.FileName;
                    }
                }
            }
        }
        private void SerializeAndSave_Click(object sender, EventArgs e)
        {
            foreach (Control c in pnl.Controls)
            {
                if (c.Name.Equals("tbPathForSerialization", StringComparison.OrdinalIgnoreCase))
                {
                    if (!string.IsNullOrEmpty(c.Text))
                    {
                        try
                        {
                            var paperBook = GenPaperBookFromForm();
                            BusinessLayer.Utility.Serialize(paperBook, c.Text);
                            btnSubmit.PerformClick(); // save the object
                        }
                        catch (BusinessLayer.BookNameEmptyException ex)
                        {
                            tbLibraryItemInfo.Clear();
                            tbLibraryItemInfo.Text = ex.Message;
                        }
                    }
                }
            }
        }
        private void OpenForSerializationBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (DialogResult.OK == sfd.ShowDialog())
            {
                foreach (Control c in pnl.Controls)
                {
                    if (c.Name.Equals("tbPathForSerialization", StringComparison.OrdinalIgnoreCase))
                    {
                        c.Text = sfd.FileName;
                    }
                }
            }
        }
        #endregion

        #region Helpers
        private void Pnl_ControlAdded(object sender, ControlEventArgs e)
        {
            // bold label fonts
            foreach (var c in pnl.Controls)
            {
                if (c is Label)
                {
                    var l = c as Label;
                    l.Font = new Font(l.Font, FontStyle.Bold);
                }
            }
        }
        private void EnforceQuantity_Leave(object sender, EventArgs e)
        {
            EnforceNumeric(sender as Control);
        }
        private void EnforceNumeric(Control c)
        {
            if (!int.TryParse(c.Text, out int result))
            {
                MessageBox.Show($"{c.Name.Replace("tb", "")} can only accept integers! Try again.");
                tbCloneQuantity.Clear();
                tbCloneQuantity.Focus();
            }
        }
        private int IncrementRowPoint()
        {
            CurrentRowPoint += ROW_CONTROL_SPACING;
            return CurrentRowPoint;
        }
        private Point NextInlineControlPoint()
        {
            return new Point(previous.Location.X + previous.Width + COL_CONTROL_SPACING, previous.Location.Y);
        }
        private Point NextRowControlPoint()
        {
            return new Point(START_POINT.X, IncrementRowPoint());
        }
        private void PromptForEbookOrBook()
        {
            RefreshPnl();

            var lbl = new Label() { Text = "Select Book Type:", Height = 15, Width = 120, Location = new Point(FRAME_WIDTH / 4, FRAME_HEIGHT / 16) };
            pnl.Controls.Add(lbl);
            previous = lbl;
            ComboBox cmb = new ComboBox();
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Items.AddRange(new string[3] { "- select -", "Paperback Book", "E-Book" });
            cmb.SelectedItem = cmb.Items[0];
            cmb.Location = NextInlineControlPoint();
            cmb.Height = 15;
            cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            pnl.Controls.Add(cmb);
        }
        private BusinessLayer.Models.PaperBook GenPaperBookFromForm()
        {
            var pb = new BusinessLayer.Models.PaperBook();
            foreach (var tb in pnl.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {
                // use reflection to find object properties with matching names, set accordingly
                if (!string.IsNullOrEmpty(tb.Text))
                {
                    var prop = pb.GetType().GetProperty(tb.Name.Replace("tb", ""));
                    if (prop != null)
                    {
                        // handle by property type
                        switch (prop.PropertyType.Name.ToLower())
                        {
                            case "int32":
                                prop.SetValue(pb, int.Parse(tb.Text), null);
                                break;
                            default: // string
                                prop.SetValue(pb, tb.Text, null);
                                break;
                        }
                    }
                }
            }

            BusinessLayer.Utility.VerifyBookTitle(pb);
            return pb;
        }
        private void RefreshPnl()
        {
            CurrentRowPoint = START_POINT.Y;
            pnl.Controls.Clear();
            tbLibraryItemInfo.Clear();
        }
        private BusinessLayer.Models.LibraryItem GenItemFromForm()
        {
            var li = new BusinessLayer.Models.LibraryItem();
            foreach (var tb in pnl.Controls.OfType<TextBox>().OrderBy(tb => tb.TabIndex))
            {
                // use reflection to find object properties with matching names, set accordingly
                if (!string.IsNullOrEmpty(tb.Text))
                {
                    var prop = li.GetType().GetProperty(tb.Name.Replace("tb", ""));
                    if (prop != null)
                    {
                        // handle by property type
                        switch (prop.PropertyType.Name.ToLower())
                        {
                            case "int32":
                                prop.SetValue(li, int.Parse(tb.Text), null);
                                break;
                            default: // string
                                prop.SetValue(li, tb.Text, null);
                                break;
                        }
                    }
                }

            }
            return li;
        }
        private void PrintProperties<T>(T obj)
        {
            tbLibraryItemInfo.Clear();
            obj.GetType().GetProperties().ToList().ForEach(p =>
            {
                tbLibraryItemInfo.Text += $"{p.Name} - {p.GetValue(obj)}\r\n";
            });
        }
        private void PrintPnlFormInfo()
        {
            tbLibraryItemInfo.Clear();
            foreach (var c in pnl.Controls)
            {
                if (c is TextBox)
                {
                    var tb = c as TextBox;
                    tbLibraryItemInfo.Text += $"{tb.Name.Replace("tb", "")}: {tb.Text}\r\n";
                }
            }
            tbLibraryItemInfo.Text += "Saved item(s) to DB.\r\n";
        }
        #endregion   
    }
}
