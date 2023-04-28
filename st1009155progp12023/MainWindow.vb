Imports System.Collections.ObjectModel
Imports System.Windows

Namespace st1009155progp12023
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window
        Private modules As ObservableCollection(Of [Module]) = New ObservableCollection(Of [Module])()

        Public Sub New()
            Me.InitializeComponent()
            Me.moduleDataGrid.ItemsSource = modules
        End Sub

        Private Sub AddButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim [module] = New [Module] With {
    .Code = Me.codeTextBox.Text,
    .Name = Me.nameTextBox.Text,
    .Credits = Integer.Parse(Me.creditsTextBox.Text),
    .ClassHoursPerWeek = Integer.Parse(Me.classHoursTextBox.Text)
}
            modules.Add([module])
        End Sub
    End Class
End Namespace
