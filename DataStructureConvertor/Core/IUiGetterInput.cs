using System.Windows.Forms;

namespace DataStructureConvertor.Core
{
    public interface IUiGetterInput
    {
        bool ConstructorParameter(IWin32Window win);

        string Text { get; }
                
    }
}
