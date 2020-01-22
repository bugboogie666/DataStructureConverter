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
    class OpenDBConnectionGetter : IUiGetterInput
    {
        public string Text { get; private set; } = string.Empty;
                

        public bool ConstructorParameter(IWin32Window win)
        {
            using (var dialog = new DataConnectionDialog())
            {
                dialog.DataSources.Add(DataSource.SqlDataSource); //(local)\SQLEXPRESS
                //DataSource.AddStandardDataSources(dialog);
                //TODO - prepis to takto -> dialog.Show(win)

                if (dialog.ShowDialog(win) == DialogResult.OK)
                {
                    this.Text = dialog.ConnectionString;
                    return true;
                }

                //if (DataConnectionDialog.Show(dialog,win) == DialogResult.OK)
                //{
                //    this.Text = dialog.ConnectionString;
                //    return true;
                //}
                
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}
