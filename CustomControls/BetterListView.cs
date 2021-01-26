using System.Windows.Forms;
using System.Linq;
namespace CustomControls
{
    public class BetterListView : ListView
    {
        public bool sortable { get; set; }
        private ColumnHeader SortingColumn = null;

        public bool HasItem
        {
            get
            {
                return this.Items.Count > 0;
            }
        }
        public bool HasSelected
        {
            get
            {
                return this.SelectedItems.Count > 0;
            }
        }

        public ListViewItem SelectedItem
        {
            get
            {
                if (HasSelected)
                {
                    return this.SelectedItems[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public ListViewItem Get(int id)
        {
            return this.Items[id];
        }

        public string[] Get(int id,bool list = true)
        {
           return  this.Items[id].SubItems.Cast<ListViewItem.ListViewSubItem>().Select(o => o.Text).ToArray();
        }


        
        public ListViewItem Add(ListViewItem lv)
        {
           return  this.Items.Add(lv);
        }

        public ListViewItem Add(string[] s)
        {
            return this.Items.Add(new ListViewItem(s));
        }
        public string[] GetColumnsName()
        {
            return this.Columns.Cast<ColumnHeader>().Select(o => o.Text).ToArray();
        }

       
        public ListViewItem Search(string keyword,int column=0,bool partial=false)
        {
            ListViewItem lv = null;
            foreach (ListViewItem item in this.Items)
            {
                var searchstr = item.SubItems[column].Text;
                if (partial)
                {
                    if (searchstr.Contains(keyword))
                    {
                        lv = item;
                        break;
                    }
                }
                else
                {
                    if (searchstr==keyword)
                    {
                        lv = item;
                        break;
                    }
                }
            }
            return lv;
        }
        public BetterListView()
        {
            this.View = View.Details;
            this.GridLines = true;
            this.FullRowSelect = true;
            this.sortable = false;
        }

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            if (this.sortable)
            {

                ColumnHeader new_sorting_column = this.Columns[e.Column];

                // Figure out the new sorting order.
                System.Windows.Forms.SortOrder sort_order;
                if (SortingColumn == null)
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }
                else
                {
                    // See if this is the same column.
                    if (new_sorting_column == SortingColumn)
                    {
                        // Same column. Switch the sort order.
                        if (SortingColumn.Text.StartsWith("> "))
                        {
                            sort_order = SortOrder.Descending;
                        }
                        else
                        {
                            sort_order = SortOrder.Ascending;
                        }
                    }
                    else
                    {
                        // New column. Sort ascending.
                        sort_order = SortOrder.Ascending;
                    }

                    // Remove the old sort indicator.
                    SortingColumn.Text = SortingColumn.Text.Substring(2);
                }

                // Display the new sort order.
                SortingColumn = new_sorting_column;
                if (sort_order == SortOrder.Ascending)
                {
                    SortingColumn.Text = "> " + SortingColumn.Text;
                }
                else
                {
                    SortingColumn.Text = "< " + SortingColumn.Text;
                }

                // Create a comparer.
                this.ListViewItemSorter =
                    new ListViewComparer(e.Column, sort_order);

                // Sort.
                this.Sort();
                base.OnColumnClick(e);
            }
        }

    }
}
