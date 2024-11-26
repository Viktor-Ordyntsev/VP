using System;
using System.Windows.Forms;

namespace SortedListExample
{
    public partial class Form1 : Form
    {
        private GenericsAscSortedList<int> sortedList;

        public Form1()
        {
            InitializeComponent();
            sortedList = new GenericsAscSortedList<int>();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {  
                sortedList.Add(value);
                UpdateListDisplay();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Max: {sortedList.Max()}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Min: {sortedList.Min()}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int index))
            {
                try
                {
                    lblelement.Text = sortedList.Get(index).ToString();
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid index.");
            }
        }

        private void UpdateListDisplay()
        {
            lblList.Text = sortedList.ToString();
            lblCount.Text = sortedList.Count.ToString();
        }
    }
}