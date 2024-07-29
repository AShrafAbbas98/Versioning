using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;

namespace Versioning
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            string revitVeriosn = null;

#if Revit_2023
            revitVeriosn = "2023";
#elif Revit_2022
            revitVeriosn = "2022";
#endif

            MessageBox.Show($"This line of code is for Revit {revitVeriosn}",
                             "Multi-Version",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

            return Result.Succeeded;
        }
    }
}
