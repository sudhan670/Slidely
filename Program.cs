Imports System
Imports System.Windows.Forms

Module Program
    <STAThread>
    Sub Main(args As String())
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        MessageBox.Show("Hello, this is a popup message!")
    End Sub
End Module
