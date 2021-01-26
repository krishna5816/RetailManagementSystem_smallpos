using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace CustomControls
{


    public enum TextboxType
    {
        Text, Integer, Decimal
    }

    public class BetterTextBox : System.Windows.Forms.TextBox
    {
        public delegate void enterHandler();
        public event enterHandler enter;
        public TextboxType textboxType { get; set; }

        public string Rules { get; set; }
        public string prepend { get; set; } = "";
        public string append { get; set; } = "";
        public int intVal
        {
            get
            {
                try
                {
                    var str = this.Text;
                    if (prepend != "")
                    {

                        str = str.Replace(prepend, "");
                    }
                    if (append != "")
                    {
                        str = str.Replace(append, "");

                    }

                    return Convert.ToInt32(str);
                }
                catch (Exception)
                {

                    return 0;
                }
            }
            set
            {
                if (this.textboxType == TextboxType.Integer)
                {

                    this.Text = append + value.ToString() + prepend;

                }
            }
        }

        public decimal decVal
        {
            get
            {
                try
                {
                    var str = this.Text;
                    if (prepend != "")
                    {

                        str = str.Replace(prepend, "");
                    }
                    if (append != "")
                    {

                        str = str.Replace(append, "");
                    }
                    return Convert.ToDecimal(str);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0m;
                }
            }
            set
            {
                if (this.textboxType == TextboxType.Decimal)
                {
                    this.Text = prepend + value.ToString("0.#############") + append;

                }
            }
        }
        public bool isPhoneno()
        {
            var val = false;
            if (this.Text.Length >= 9)
            {
                val = true;
            }
            return val;
        }

        public bool isEmail()
        {
            return new EmailAddressAttribute().IsValid(this.Text);
        }

        public bool isEmpty()
        {
            return this.Text.Trim() == "";
        }
        public BetterTextBox()
        {
            this.textboxType = TextboxType.Text;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                enter?.Invoke();
                return;
            }
            if (this.textboxType == TextboxType.Integer)
            {
                if ((e.KeyValue > 47 && e.KeyValue < 58) || (e.KeyValue == 13) || (e.KeyValue == 8) || (e.KeyValue == 37) || (e.KeyValue == 38) || (e.KeyValue == 39) || (e.KeyValue == 40) || (e.KeyValue > 95 && e.KeyValue < 106))
                {
                    e.SuppressKeyPress = false;

                }
                else
                {
                    e.SuppressKeyPress = true;
                }
                return;

            }
            else if (textboxType == TextboxType.Decimal)
            {
                if ((e.KeyValue > 47 && e.KeyValue < 58) || (e.KeyValue == 190) || (e.KeyValue == 13) || (e.KeyValue == 8) || (e.KeyValue == 39) || (e.KeyValue == 40) || (e.KeyValue > 95 && e.KeyValue < 106))
                {
                    if (this.Text.Contains(".") && (e.KeyValue == 190))
                    {
                        e.SuppressKeyPress = true;
                        return;
                    }

                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
                return;
            }
            base.OnKeyDown(e);
        }

        public bool isvalid()
        {

            if (Rules.Trim().Length > 0)
            {
                var sections = Rules.Split('|');
                foreach (var item in sections)
                {
                    var rule = item.Split(',');
                    switch (rule[0])
                    {
                       
                        default:
                            break;

                    }
                }
            }


            return true; ;
        }

        public void text(object o)
        {
            try
            {
                this.Text = o.ToString();
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
    }
}
