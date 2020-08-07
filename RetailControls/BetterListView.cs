using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
namespace RetailControls
{
    public class BetterListView:ListView
    {
        private ListViewColumnSorter lvwColumnSorter;
        public BetterListView()
        {
            this.FullRowSelect = true;
            this.GridLines = true;
            this.MultiSelect = false;
            this.View = View.Details;
            lvwColumnSorter = new ListViewColumnSorter();
            this.ListViewItemSorter = lvwColumnSorter;
        }
        public void addColumns(string[] arr)
        {
            foreach (string item in arr)
            {
                this.Columns.Add(item);
            }
        }

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }


            this.Sort();
            
        }
    }
}
