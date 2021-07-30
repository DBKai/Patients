using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Med
{
    public class Filter
    {
        // Фильтрация данных
        public static string txbFilter_TextChanged(Control control)
        {
            string filter = null;
            try
            {
                // Выбираем все контролы типа TextBox, содержащиеся на ExpandablePanel, где текст не пустой 
                // и записываем в класс KeyValuePair, содержащий пары: Имя TextBox, Содержимое TextBox
                var pairs = control.Controls.OfType<TextBox>()
                                     .Where(tb => !string.IsNullOrEmpty(tb.Text))
                                     .Select(tb => new KeyValuePair<string, string>(tb.Name.Remove(0, 9), tb.Text))
                                     .ToArray();
                // Если хотя бы один TextBox существует
                if (pairs.Length != 0)
                {
                    // Создаем строку для свойства Filter объекта BindingSource
                    var sb = new StringBuilder(string.Format(" {0} LIKE '%{1}%' ", pairs[0].Key, pairs[0].Value));
                    // Если существуют еще пары TextBox
                    for (int i = 1; i < pairs.Length; i++)
                    {
                        // то добавляем их в конец к полученной строке 
                        sb.AppendFormat(" AND {0} LIKE '%{1}%' ", pairs[i].Key, pairs[i].Value);
                    }
                    // Присваиваем получившуюся строку к свойству Filter
                    filter = sb.ToString();
                }
                else
                {
                    // Иначе обнуляем фильтр у BindingSource
                    filter = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return filter;
        }
    }
}
