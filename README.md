# Creating a WPF doughnut chart to visualize the New European Parliament's composition – 2024.
## Description
The doughnut chart is used to show the relationship between parts of the data and the whole data.

## Customization
We can customize the color, border, and width of the doughnut segment using the [Palette](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_Palette), [Stroke](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeries.html#Syncfusion_UI_Xaml_Charts_ChartSeries_Stroke), and [StrokeThickness](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeries.html#Syncfusion_UI_Xaml_Charts_ChartSeries_StrokeThickness) properties respectively. Data points below a certain value are grouped using the [GroupTo](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.CircularSeriesBase.html#Syncfusion_UI_Xaml_Charts_CircularSeriesBase_GroupTo) property. The [StartAngle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.CircularSeriesBase.html#Syncfusion_UI_Xaml_Charts_CircularSeriesBase_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.CircularSeriesBase.html#Syncfusion_UI_Xaml_Charts_CircularSeriesBase_EndAngle) properties are used to alter the beginning and end positions of a chart segment.

## Center View
The CenterView property of the DoughnutSeries allows you to add any view to the center of the doughnut chart. It helps to understand the information about the provided data.

This article explains composition of the European Parliament based on provisional results of the European Election 2024.
<img width="915" alt="output" src="https://github.com/SyncfusionExamples/Creating-a-WPF-doughnut-chart-to-visualize-the-composition-of-the-New-European-Parliament-in-2024/assets/103025761/4ad88522-fc58-4adf-80ad-b6212bed128e">

Troubleshooting
Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
For a step-by-step procedure, refer to the  [European Parliament Blog .]()
