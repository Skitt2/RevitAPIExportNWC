using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPIExportNWC
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            var nwcOption = new NavisworksExportOptions();
            doc.Export(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "3dmodel.nwc", nwcOption);
            return Result.Succeeded;
            TaskDialog.Show("Экспорт", "Экспорт проведен удачно");
        }
    }
}
