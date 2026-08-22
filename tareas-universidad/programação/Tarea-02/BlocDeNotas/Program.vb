Imports System.Windows.Forms

Friend Module Program

    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.Run(New frmBlocNotas())
    End Sub

End Module