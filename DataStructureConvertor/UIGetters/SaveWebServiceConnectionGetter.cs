using DataStructureConvertor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureConvertor.UIGetters
{
    class SaveWebServiceConnectionGetter: IUiGetterOutput
    {
        public string Text { get; private set; } = string.Empty;

        public bool ConstructorParameter(IWin32Window win)
        {
            using (var dialog = new UrlDialog())
            {
                dialog.ShowDialog(win);
                if (dialog.TextUrl != null)
                {
                    this.Text = dialog.TextUrl;
                    return true;

                }
            }
            return false;
        }

    }
}
