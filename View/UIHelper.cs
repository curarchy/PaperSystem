using System;
using System.Windows.Forms;
using PaperSystem.Entity;
using System.Collections.Generic;

namespace PaperSystem.View
{
    public static class UIHelper
    {
        /// <summary>
        /// 获取checkbox的取值。值在tag里，必须是int。
        /// </summary>
        /// <param name="controlCllection"></param>
        /// <returns></returns>
        public static int GetCheckedRadioButton(Control.ControlCollection controlCllection)
        {
            foreach (var item in controlCllection)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = item as RadioButton;
                    if (radioButton.Checked)
                    {
                        return Convert.ToInt16(radioButton.Tag);
                    }
                }
            }
            return 0;
        }

        /// <summary>
        /// 设置checkbox的取值。值在tag里，必须是int。
        /// </summary>
        /// <param name="controlCllection"></param>
        /// <returns></returns>
        public static void SetCheckedRadioButton(Control.ControlCollection controlCllection, int value)
        {
            foreach (var item in controlCllection)
            {
                if (item is RadioButton)
                {
                    RadioButton radioButton = item as RadioButton;
                    if (Convert.ToInt16(radioButton.Tag) == value)
                    {
                        radioButton.Checked = true;
                    }
                }
            }
        }

        /// <summary>
        /// 获取checkbox的取值。值在tag里，必须是int。
        /// </summary>
        /// <param name="controlCllection"></param>
        /// <returns></returns>
        public static List<int> GetCheckedCheckboxs(Control.ControlCollection controlCllection)
        {
            List<int> result = new List<int>();
            foreach (var item in controlCllection)
            {
                if (item is CheckBox)
                {
                    CheckBox checkbox = item as CheckBox;
                    if (checkbox.Checked)
                    {
                        result.Add(Convert.ToInt16(checkbox.Tag));
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 获取选中的行id
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static List<int> GetSelectedIndex(DataGridView dataGridView)
        {
            List<int> result = new List<int>();
            DataGridViewSelectedRowCollection selectedRows = dataGridView.SelectedRows;

            foreach (DataGridViewRow item in selectedRows)
            {
                // id的话，有两个会出问题。。。
                result.Add(Convert.ToInt16(item.Cells[0].Value));
            }

            return result;
        }

        /// <summary>
        /// 根据题目类型返回所选题目
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<int> GetSelectedIndex(DataGridView dataGridView, int type)
        {
            List<int> result = new List<int>();
            DataGridViewSelectedRowCollection selectedRows = dataGridView.SelectedRows;

            foreach (DataGridViewRow item in selectedRows)
            {
                if (type == Convert.ToInt16(item.Cells["Type"].Value))
                {
                    result.Add(Convert.ToInt16(item.Cells[0].Value));
                }
            }

            return result;
        }


        public static List<int> GetIndex(DataGridViewRowCollection rows)
        {
            List<int> result = new List<int>();
            foreach (DataGridViewRow item in rows)
            {
                // id的话，有两个会出问题。。。
                result.Add(Convert.ToInt16(item.Cells[0].Value));
            }

            return result;
        }

        public static List<int> GetCheckedList(CheckedListBox control)
        {
            
            List<int> result = new List<int>();
            foreach (CommonEntity item in control.CheckedItems)
            {
                result.Add(item.Key);
            }
            return result;
        }
    }
}
