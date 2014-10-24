using System;
using System.Windows.Forms;
using PaperSystem.Entity;

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
    }
}
