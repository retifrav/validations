using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace validations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Событие, когда в полях ввода меняется текст
        private void textBox_inn_TextChanged(object sender, EventArgs e)
        {
            label_inn_result.ForeColor = Color.Black;
            label_inn_result.Text = "результат проверки";
            button_check.Enabled = true;
        }

        private void textBox_kpp_TextChanged(object sender, EventArgs e)
        {
            label_kpp_result.ForeColor = Color.Black;
            label_kpp_result.Text = "результат проверки";
            button_check.Enabled = true;
        }

        private void textBox_ogrn_TextChanged(object sender, EventArgs e)
        {
            label_ogrn_result.ForeColor = Color.Black;
            label_ogrn_result.Text = "результат проверки";
            button_check.Enabled = true;
        }
        #endregion

        private void button_check_Click(object sender, EventArgs e)
        {
            button_check.Enabled = false;

            // проверка ИНН
            if (check_INN(textBox_inn.Text))
            {
                label_inn_result.ForeColor = Color.Green;
                label_inn_result.Text = "введённый ИНН прошёл проверку";
            }
            else
            {
                label_inn_result.ForeColor = Color.Red;
                label_inn_result.Text = "введённый ИНН не прошёл проверку";
            }
            
            // проверка КПП
            if (check_KPP(textBox_kpp.Text))
            {
                label_kpp_result.ForeColor = Color.Green;
                label_kpp_result.Text = "введённый КПП прошёл проверку";
            }
            else
            {
                label_kpp_result.ForeColor = Color.Red;
                label_kpp_result.Text = "введённый КПП не прошёл проверку";
            }
            
            // проверка ОГРН
            if (check_OGRN(textBox_ogrn.Text))
            {
                label_ogrn_result.ForeColor = Color.Green;
                label_ogrn_result.Text = "введённый ОГРН прошёл проверку";
            }
            else
            {
                label_ogrn_result.ForeColor = Color.Red;
                label_ogrn_result.Text = "введённый ОГРН не прошёл проверку";
            }
        }

        #region Проверка ИНН
        /// <summary>
        /// проверка ИНН по контрольной цифре
        /// </summary>
        /// <param name="INN">ИНН для проверки</param>
        /// <returns>true - если проходит проверку, false - если не проходит проверку</returns>
        public bool check_INN(string INNstring)
        {
            // является ли вообще числом
            try { Int64.Parse(INNstring); } catch { return false; }

            // проверка на 10 и 12 цифр
            if (INNstring.Length != 10 && INNstring.Length != 12) { return false; }

            // проверка по контрольным цифрам
            if (INNstring.Length == 10) // для юридического лица
            {
                int dgt10 = 0;
                try
                {
                    dgt10 = (((2 * Int32.Parse(INNstring.Substring(0,1))
                        + 4 * Int32.Parse(INNstring.Substring(1,1))
                        + 10 * Int32.Parse(INNstring.Substring(2,1))
                        + 3 * Int32.Parse(INNstring.Substring(3,1))
                        + 5 * Int32.Parse(INNstring.Substring(4,1))
                        + 9 * Int32.Parse(INNstring.Substring(5,1))
                        + 4 * Int32.Parse(INNstring.Substring(6,1))
                        + 6 * Int32.Parse(INNstring.Substring(7,1))
                        + 8 * Int32.Parse(INNstring.Substring(8,1))) % 11) % 10);
                }
                catch { return false; }

                if (Int32.Parse(INNstring.Substring(9,1)) == dgt10) { return true; }
                else { return false; }
            }
            else // для физического лица
            {
                int dgt11 = 0, dgt12 = 0;
                try
                {
                    dgt11 = (((
                        7 * Int32.Parse(INNstring.Substring(0,1))
                        + 2 * Int32.Parse(INNstring.Substring(1,1))
                        + 4 * Int32.Parse(INNstring.Substring(2,1))
                        + 10 * Int32.Parse(INNstring.Substring(3,1))
                        + 3 * Int32.Parse(INNstring.Substring(4,1))
                        + 5 * Int32.Parse(INNstring.Substring(5,1))
                        + 9 * Int32.Parse(INNstring.Substring(6,1))
                        + 4 * Int32.Parse(INNstring.Substring(7,1))
                        + 6 * Int32.Parse(INNstring.Substring(8,1))
                        + 8 * Int32.Parse(INNstring.Substring(9,1))) % 11) % 10);
                    dgt12 = (((
                        3 * Int32.Parse(INNstring.Substring(0,1))
                        + 7 * Int32.Parse(INNstring.Substring(1,1))
                        + 2 * Int32.Parse(INNstring.Substring(2,1))
                        + 4 * Int32.Parse(INNstring.Substring(3,1))
                        + 10 * Int32.Parse(INNstring.Substring(4,1))
                        + 3 * Int32.Parse(INNstring.Substring(5,1))
                        + 5 * Int32.Parse(INNstring.Substring(6,1))
                        + 9 * Int32.Parse(INNstring.Substring(7,1))
                        + 4 * Int32.Parse(INNstring.Substring(8,1))
                        + 6 * Int32.Parse(INNstring.Substring(9,1))
                        + 8 * Int32.Parse(INNstring.Substring(10,1))) % 11) % 10);
                }
                catch { return false; }
                if (Int32.Parse(INNstring.Substring(10,1)) == dgt11
                    && Int32.Parse(INNstring.Substring(11,1)) == dgt12) { return true; }
                else { return false; }
            }
        }
        #endregion
        
        #region Проверка КПП
        /// <summary>
        /// проверка КПП по регулярному выражению
        /// </summary>
        /// <param name="KPPstring">КПП для проверки</param>
        /// <returns>true - если проходит проверку, false - если не проходит проверку</returns>
        public bool check_KPP(string KPPstring)
        {
            return new Regex(@"^\d{4}[\dA-Z][\dA-Z]\d{3}$").IsMatch(KPPstring);
        }
        #endregion

        #region Проверка ОГРН
        /// <summary>
        /// проверка ОГРН по контрольной цифре
        /// </summary>
        /// <param name="OGRNstring">ОГРН для проверки</param>
        /// <returns>true - если проходит проверку, false - если не проходит проверку</returns>
        public bool check_OGRN(string OGRNstring)
        {
            // является ли вообще числом
            long number = 0;
            try { number = Int64.Parse(OGRNstring); }
            catch { return false; }

            // проверка на 13 и 15 цифр
            if (OGRNstring.Length != 13 && OGRNstring.Length != 15) { return false; }

            // проверка по контрольным цифрам
            if (OGRNstring.Length == 13) // для юридического лица
            {
                // остаток от деления
                int num12 = (int)Math.Floor(((double)number / 10) % 11);
                int dgt13 = -1;
                // если остаток равен 10, то берём 0, если нет, то берём его самого
                if (num12 == 10) { dgt13 = 0; } else { dgt13 = num12; }
                // ну и теперь сравниваем с контрольной цифрой
                if (Int32.Parse(OGRNstring.Substring(12, 1)) == dgt13) { return true; }
                else { return false; }
            }
            else // для индивидуального предпринимателя
            {
                // остаток от деления
                int num14 = (int)Math.Floor(((double)number / 10) % 13);
                int dgt15 = num14 % 10;
                // ну и теперь сравниваем с контрольной цифрой
                if (Int32.Parse(OGRNstring.Substring(14, 1)) == dgt15) { return true; }
                else { return false; }
            }
        }
        #endregion


        private void очиститьВсеПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_inn.Text = " ";
            textBox_inn.Clear();
            textBox_kpp.Text = " ";
            textBox_kpp.Clear();
            textBox_ogrn.Text = " ";
            textBox_ogrn.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
