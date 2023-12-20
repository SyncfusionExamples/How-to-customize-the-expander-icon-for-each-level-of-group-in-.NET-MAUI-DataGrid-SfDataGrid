using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using System.Globalization;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
    }

    public class GroupCaptionConverter : IValueConverter
    {
        public string Name { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as Group : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                if ((value as Group).Parent is TopLevelGroup)
                {
                    return dataGrid.View.TopLevelGroup.GetGroupCaptionText((value as Group), "{ColumnName} : {Key} - {ItemsCount} Items", dataGrid.GroupColumnDescriptions[0].ColumnName);
                }
                else
                {
                    return dataGrid.View.TopLevelGroup.GetGroupCaptionText((value as Group), "{ColumnName} : {Key} - {ItemsCount} Items", dataGrid.GroupColumnDescriptions[1].ColumnName);
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }


    public class GroupBackgroundColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as Group : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                if ((value as Group).Parent is TopLevelGroup)
                {
                    return "LightGray";
                }
                else
                {
                    return "LightBlue";
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class GroupIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var data = value != null ? value as Group : null;
            if (data != null)
            {
                SfDataGrid dataGrid = (SfDataGrid)parameter;
                if ((value as Group).Parent is TopLevelGroup)
                {
                    return "upword_icon.png";
                }
                else
                {
                    return "downward_icon.png";
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

}
