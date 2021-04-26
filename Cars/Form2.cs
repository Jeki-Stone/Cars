using Cars.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Автор: Кузугашев Иван Владимирович
/// Дата: 26.04.2021
/// </summary>
namespace Cars
{
    public partial class Form2 : Form
    {
        string labelText;
        List<FinalResult> finalResults;

        public Form2( )
        {
            InitializeComponent();
        }

        public Form2(string labelText, List<FinalResult> finalResults)
        {
            InitializeComponent();
            this.labelText = labelText;
            this.finalResults = finalResults;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = labelText;
            foreach (var item in finalResults)
            {
                dataGridViewFinalists.Rows.Add(item.Position, item.CarName, (item.SpentTime).ToString(@"hh\:mm\:ss\.fff"));
            }
            //dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            //for (int i = 0; i < finalResults.Count; i++)
            //{
            //    dataGridView1[0, i].Value = i+1;
            //}
        }
    }
}
