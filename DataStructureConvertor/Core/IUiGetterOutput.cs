using System.Windows.Forms;

namespace DataStructureConvertor.Core
{
    public interface IUiGetterOutput
    {
        bool ConstructorParameter(IWin32Window win);

        string Text { get; }

            }
}
