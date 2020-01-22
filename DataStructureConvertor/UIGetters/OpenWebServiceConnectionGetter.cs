using DataStructureConvertor.Core;
using System.Windows.Forms;

namespace DataStructureConvertor.UIGetters
{
    class OpenWebServiceConnectionGetter : IUiGetterInput
    {
        
        public string Text { get; private set; } = string.Empty;

        public bool ConstructorParameter(IWin32Window win)
        {
            using (var dialog = new UrlDialog())
            {           
                dialog.ShowDialog(win);
                if(dialog.TextUrl != null)
                { 
                    this.Text = dialog.TextUrl;
                    return true;

                }
            }
            return false;
        }
      
    }
}
