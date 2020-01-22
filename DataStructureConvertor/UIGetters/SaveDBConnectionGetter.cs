using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureConvertor.Core;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace DataStructureConvertor.UIGetters
{
    class SaveDBConnectionGetter : IUiGetterOutput
    {
        public string Text { get; private set; } = string.Empty;
                

        public bool ConstructorParameter(IWin32Window win)
        {
            using (var dialog = new DataConnectionDialog())
            {
                dialog.DataSources.Add(DataSource.SqlDataSource); //(local)\SQLEXPRESS
                //DataSource.AddStandardDataSources(dialog);
                if (DataConnectionDialog.Show(dialog, win) == DialogResult.OK)
                {
                    this.Text = dialog.ConnectionString;
                    return true;
                }

            }
            return false;
            //throw new NotImplementedException();
        }
    }
}
