using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_WinForm
{
    public partial class formSLS : Form
    {
        private readonly int FRAME_WIDTH;
        private readonly int FRAME_HEIGHT;
        private Point START_POINT;
        private const int COL_CONTROL_SPACING = 10;
        private const int ROW_CONTROL_SPACING = 20;
        private const int TB_CONTROL_WIDTH = 200;
        private const int LBL_CONTROL_WIDTH = 200;
        private Control previous;

        int CurrentRowPoint { get; set; }

        public formSLS()
        {
            InitializeComponent();
            pnl.BackColor = Color.LightGray;
            cmbItemType.SelectedIndex = 0;
            cmbItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            tbCloneQuantity.Leave += TbCloneQuantity_Leave;
            pnl.ControlAdded += Pnl_ControlAdded;
            
            FRAME_HEIGHT = this.Height;
            FRAME_WIDTH = this.Width;
            START_POINT = new Point(FRAME_WIDTH / 16, FRAME_HEIGHT / 16);// new Point(10, 10); // cols = x, rows = y (margin)
        }

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

        private void TbCloneQuantity_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCloneQuantity.Text, out int result))
            {
                MessageBox.Show("Clone Quantity can only accept integers! Try again.");
                tbCloneQuantity.Clear();
                tbCloneQuantity.Focus();
            }  
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            var lbl = new Label() { Text = "Select Book Type:", Height = 15, Width=120, Location = new Point(FRAME_WIDTH / 4, FRAME_HEIGHT / 4) };
            pnl.Controls.Add(lbl);
            previous = lbl;
            ComboBox cmb = new ComboBox();
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.Items.AddRange(new string[3] {"- select -", "Paperback Book", "E-Book" });
            cmb.SelectedItem = cmb.Items[0];
            cmb.Location = NextInlineControlPoint();
            cmb.Height = 15;
            cmb.SelectedIndexChanged += Cmb_SelectedIndexChanged;
            pnl.Controls.Add(cmb);
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            if (obj.SelectedIndex == 1) // book
            {
                SetupBook();
            }
            if (obj.SelectedIndex == 2) // e-book
            {
                SetupEBook();
            }
        }

        private void SetupEBook()
        {
            SetupBook();
            var lblWebUri = new Label() { Text = "Enter Web Uri:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblWebUri);
            previous = lblWebUri;
            var tbWebUri = new TextBox() { Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbWebUri);
            previous = tbWebUri;
        }

        private void SetupJournal()
        {
            RefreshPnl();

            var lblISSN = new Label() { Text = "Enter ISSN #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = START_POINT };
            pnl.Controls.Add(lblISSN);
            previous = lblISSN;
            var tbISSN = new TextBox() { Location = NextInlineControlPoint() };
            pnl.Controls.Add(tbISSN);
            previous = tbISSN;

            var lblVolumeNum = new Label() { Text = "Enter Volume #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblVolumeNum);
            previous = lblVolumeNum;
            var tbVolumeNum = new TextBox() { Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbVolumeNum);
            previous = tbVolumeNum;
        }

        private void SetupMagazine()
        {
            RefreshPnl();

            var lblNumArticles = new Label() { Text = "Enter # of Articles:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = START_POINT };
            pnl.Controls.Add(lblNumArticles);
            previous = lblNumArticles;
            var tbNumArticles = new TextBox() { Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbNumArticles);
            previous = tbNumArticles;

            var lblAdvertisers = new Label() { Text = "Enter each advertiser on a new line:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblAdvertisers);
            previous = lblAdvertisers;
            var tbAdvertisers = new TextBox() { Location = NextInlineControlPoint(), Multiline = true, Height = 40, Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbAdvertisers);
            previous = tbAdvertisers;
        }

        private void SetupBook()
        {
            RefreshPnl();

            var lblISBN = new Label() { Text = "Enter ISBN #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = START_POINT };
            pnl.Controls.Add(lblISBN);
            previous = lblISBN;
            var tbISBN = new TextBox() { Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbISBN);
            previous = tbISBN;

            var lblEdition = new Label() { Text = "Enter Edition #:", Height = 15, Width = LBL_CONTROL_WIDTH, Location = NextRowControlPoint() };
            pnl.Controls.Add(lblEdition);
            previous = lblEdition;
            var tbEdition = new TextBox() { Location = NextInlineControlPoint(), Width = TB_CONTROL_WIDTH };
            pnl.Controls.Add(tbEdition);
            previous = tbEdition;
        }

        private void cbClone_CheckedChanged(object sender, EventArgs e)
        {
            lblCloneQuantity.Visible = cbClone.Checked;
            tbCloneQuantity.Visible = cbClone.Checked;
        }

        private void RefreshPnl()
        {
            CurrentRowPoint = START_POINT.Y;
            pnl.Controls.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshPnl();
            cbClone.Checked = false;
            cmbItemType.SelectedIndex = 0;
            lblFormInstructions.Visible = false;
        }
    }
}
