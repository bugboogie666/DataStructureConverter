using DataStructureConvertor.Core;
using System.Windows.Forms;

namespace DataStructureConvertor.UIGetters
{
    public class SaveFileNameGetter : IUiGetterOutput
    {
        public string Text { get; private set; } = string.Empty;

        public bool ConstructorParameter(IWin32Window win)
        {
            using (var dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog(win) == DialogResult.OK)
                {
                    this.Text = dlg.FileName;

                    return true;
                }
            }

            return false;
        }
    }
}
